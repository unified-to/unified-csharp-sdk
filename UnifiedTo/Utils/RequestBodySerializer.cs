
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reflection;
    using System.Text;

    internal class RequestBodySerializer
    {
        public static HttpContent? Serialize(
            object? request,
            string requestFieldName,
            string serializationMethod,
            string format = ""
        )
        {
            if (request == null)
            {
                return null;
            }

            if (Utilities.IsClass(request))
            {
                var prop = GetPropertyInfo(request, requestFieldName);

                if (prop != null)
                {
                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetRequestMetadata();
                    if (metadata != null)
                    {
                        var fieldValue = prop.GetValue(request);
                        if (fieldValue == null)
                        {
                            return null;
                        }

                        return TrySerialize(
                            fieldValue,
                            requestFieldName,
                            serializationMethod,
                            metadata.MediaType ?? ""
                        );
                    }
                }
            }

            // Not an object or flattened request
            return TrySerialize(request, requestFieldName, serializationMethod, "", format);
        }

        private static HttpContent? TrySerialize(
            object request,
            string requestFieldName,
            string serializationMethod,
            string mediaType = "",
            string format = ""
        )
        {
            if (mediaType == "")
            {
                mediaType = new Dictionary<string, string>()
                {
                    { "json", "application/json" },
                    { "form", "application/x-www-form-urlencoded" },
                    { "multipart", "multipart/form-data" },
                    { "raw", "application/octet-stream" },
                    { "string", "text/plain" },
                }[serializationMethod];
            }

            switch (serializationMethod)
            {
                case "json":
                    return SerializeJson(request, mediaType, format);
                case "form":
                    return SerializeForm(request, requestFieldName, mediaType);
                case "multipart":
                    return SerializeMultipart(request, mediaType);
                default:
                    // if request is a byte array, use it directly otherwise encode
                    if (request.GetType() == typeof(byte[]))
                    {
                        return SerializeRaw((byte[])request, mediaType);
                    }
                    else if (request.GetType() == typeof(string))
                    {
                        return SerializeString((string)request, mediaType);
                    }
                    else
                    {
                        throw new Exception(
                            "Cannot serialize request body of type "
                                + request.GetType().Name
                                + " with serialization method "
                                + serializationMethod
                                + ""
                        );
                    }
            }
        }

        private static HttpContent SerializeJson(object request, string mediaType, string format = "")
        {
            return new StringContent(Utilities.SerializeJSON(request, format), Encoding.UTF8, mediaType);
        }

        private static HttpContent SerializeForm(
            object request,
            string requestFieldName,
            string mediaType
        )
        {
            Dictionary<string, List<string>> form = new Dictionary<string, List<string>>();

            if (Utilities.IsClass(request))
            {
                var props = request.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var val = prop.GetValue(request);
                    if (val == null)
                    {
                        continue;
                    }

                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetFormMetadata();
                    if (metadata == null)
                    {
                        continue;
                    }

                    if (metadata.Json)
                    {
                        var key = metadata.Name ?? prop.Name;
                        if (key == "")
                        {
                            continue;
                        }

                        if (!form.ContainsKey(key))
                        {
                            form.Add(key, new List<string>());
                        }

                        form[key].Add(Utilities.SerializeJSON(val));
                    }
                    else
                    {
                        switch (metadata.Style)
                        {
                            case "form":
                                SerializeFormValue(
                                    metadata.Name ?? prop.Name,
                                    metadata.Explode,
                                    val,
                                    ref form
                                );
                                break;
                            default:
                                throw new Exception("Unsupported form style " + metadata.Style);
                        }
                    }
                }
            }
            else if (Utilities.IsDictionary(request))
            {
                foreach (var k in ((IDictionary)request).Keys)
                {
                    var key = k?.ToString();

                    if (key == null)
                    {
                        continue;
                    }

                    if (!form.ContainsKey(key))
                    {
                        form.Add(key, new List<string>());
                    }

                    form[key].Add(Utilities.ValueToString(((IDictionary)request)[key]));
                }
            }
            else if (Utilities.IsList(request))
            {
                foreach (var item in (IList)request)
                {
                    if (!form.ContainsKey(requestFieldName))
                    {
                        form.Add(requestFieldName, new List<string>());
                    }

                    form[requestFieldName].Add(Utilities.ValueToString(item));
                }
            }
            else
            {
                throw new Exception(
                    "Cannot serialize form data from type " + request.GetType().Name
                );
            }

            var formData = new List<KeyValuePair<string?, string?>>();

            foreach (var key in form.Keys)
            {
                foreach (var val in form[key])
                {
                    formData.Add(
                        new KeyValuePair<string?, string?>(
                            key + (form[key].Count > 1 ? "[]" : ""),
                            val
                        )
                    );
                }
            }

            return new FormUrlEncodedContent(formData);
        }

        private static HttpContent SerializeMultipart(object request, string mediaType)
        {
            var formData = new MultipartFormDataContent();

            var properties = request.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var value = prop.GetValue(request);
                if (value == null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetMultipartFormMetadata();
                if (metadata == null)
                {
                    continue;
                }

                if (metadata.File)
                {
                    if (!Utilities.IsClass(value))
                    {
                        throw new Exception(
                            "Cannot serialize multipart file from type " + value.GetType().Name
                        );
                    }

                    var fileProps = value.GetType().GetProperties();

                    byte[]? content = null;
                    string fileName = "";
                    string fieldName = "";

                    foreach (var fileProp in fileProps)
                    {
                        var fileMetadata = fileProp
                            .GetCustomAttribute<SpeakeasyMetadata>()
                            ?.GetMultipartFormMetadata();
                        if (
                            fileMetadata == null
                            || (!fileMetadata.Content && fileMetadata.Name == "")
                        )
                        {
                            continue;
                        }

                        if (fileMetadata.Content)
                        {
                            content = (byte[]?)fileProp.GetValue(value);
                        }
                        else
                        {
                            fieldName = fileMetadata.Name ?? fileProp.Name;
                            fileName = fileProp.GetValue(value)?.ToString() ?? "";
                        }
                    }

                    if (fieldName == "" || fileName == "" || content == null)
                    {
                        throw new Exception("Invalid multipart/form-data file");
                    }

                    formData.Add(new ByteArrayContent(content), fieldName, fileName);
                }
                else if (metadata.Json)
                {
                    formData.Add(
                        new StringContent(Utilities.SerializeJSON(value)),
                        metadata.Name ?? prop.Name
                    );
                }
                else if (Utilities.IsList(value))
                {
                    var values = new List<string>();

                    foreach (var item in (IList)value)
                    {
                        values.Add(Utilities.ValueToString(item));
                    }

                    foreach (var val in values)
                    {
                        formData.Add(new StringContent(val), metadata.Name ?? prop.Name);
                    }
                }
                else
                {
                    formData.Add(
                        new StringContent(Utilities.ValueToString(value)),
                        metadata.Name ?? prop.Name
                    );
                }
            }

            return formData;
        }

        private static HttpContent SerializeRaw(byte[] request, string mediaType)
        {
            var content = new ByteArrayContent(request);
            content.Headers.Add("Content-Type", mediaType);
            return content;
        }

        private static HttpContent SerializeString(string request, string mediaType)
        {
            return new StringContent(request, Encoding.UTF8, mediaType);
        }

        private static void SerializeFormValue(
            string fieldName,
            bool explode,
            object value,
            ref Dictionary<string, List<string>> form
        )
        {
            if (Utilities.IsClass(value))
            {
                if (Utilities.IsDate(value))
                {
                    if (!form.ContainsKey(fieldName))
                    {
                        form[fieldName] = new List<string>();
                    }

                    form[fieldName].Add(Utilities.ValueToString(value));
                }
                else
                {
                    var props = value.GetType().GetProperties();

                    var items = new List<string>();

                    foreach (var prop in props)
                    {
                        var val = prop.GetValue(value);
                        if (val == null)
                        {
                            continue;
                        }

                        var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetFormMetadata();
                        if (metadata == null || metadata.Name == null)
                        {
                            continue;
                        }

                        if (explode)
                        {
                            if (!form.ContainsKey(metadata.Name))
                            {
                                form[metadata.Name] = new List<string>();
                            }

                            form[metadata.Name].Add(Utilities.ValueToString(val));
                        }
                        else
                        {
                            items.Add($"{metadata.Name},{Utilities.ValueToString(val)}");
                        }
                    }

                    if (items.Count > 0)
                    {
                        if (!form.ContainsKey(fieldName))
                        {
                            form[fieldName] = new List<string>();
                        }

                        form[fieldName].Add(string.Join(",", items));
                    }
                }
            }
            else if (Utilities.IsDictionary(value))
            {
                var items = new List<string>();

                foreach (var k in ((IDictionary)value).Keys)
                {
                    var key = k?.ToString();

                    if (key == null)
                    {
                        continue;
                    }

                    if (explode)
                    {
                        if (!form.ContainsKey(key))
                        {
                            form[key] = new List<string>();
                        }

                        form[key].Add(
                            Utilities.ValueToString(((IDictionary)value)[key])
                        );
                    }
                    else
                    {
                        items.Add($"{key},{Utilities.ValueToString(((IDictionary)value)[key])}");
                    }
                }

                if (items.Count > 0)
                {
                    if (!form.ContainsKey(fieldName))
                    {
                        form[fieldName] = new List<string>();
                    }

                    form[fieldName].Add(string.Join(",", items));
                }
            }
            else if (Utilities.IsList(value))
            {
                var values = new List<string>();
                var items = new List<string>();

                foreach (var item in (IList)value)
                {
                    if (explode)
                    {
                        values.Add(Utilities.ValueToString(item));
                    }
                    else
                    {
                        items.Add(Utilities.ValueToString(item));
                    }
                }

                if (items.Count > 0)
                {
                    values.Add(string.Join(",", items));
                }

                foreach (var val in values)
                {
                    if (!form.ContainsKey(fieldName))
                    {
                        form[fieldName] = new List<string>();
                    }

                    form[fieldName].Add(val);
                }
            }
            else
            {
                if (!form.ContainsKey(fieldName))
                {
                    form[fieldName] = new List<string>();
                }

                form[fieldName].Add(Utilities.ValueToString(value));
            }
        }

        private static PropertyInfo? GetPropertyInfo(object value, string propertyName)
        {
            try
            {
                return value.GetType().GetProperty(propertyName);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
