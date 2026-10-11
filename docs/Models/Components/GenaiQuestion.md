# GenaiQuestion


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Id`                                                                          | *string*                                                                      | :heavy_check_mark:                                                            | A caller-chosen key; the matching answer is returned with the same id.        |
| `Instructions`                                                                | *string*                                                                      | :heavy_check_mark:                                                            | The question to evaluate.                                                     |
| `Options`                                                                     | List<*string*>                                                                | :heavy_minus_sign:                                                            | CHOICE: the options to select from; SCORE: the ordered levels (lowest first). |
| `Type`                                                                        | [GenaiQuestionType](../../Models/Components/GenaiQuestionType.md)             | :heavy_check_mark:                                                            | N/A                                                                           |