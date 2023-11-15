# Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.

# typed: true
# frozen_string_literal: true

require 'sorbet-runtime'
require 'faraday'
require_relative '../shared/webhook'

module OpenApiSDK
  module Operations

    class GetUnifiedWebhookRequest < OpenApiSDK::Utils::FieldAugmented
      extend T::Sig

      # ID of the Webhook
      field :id, String, { 'path_param': { 'field_name': 'id', 'style': 'simple', 'explode': false } }


      sig { params(id: String).void }
      def initialize(id: nil)
        @id = id
      end
    end


    class GetUnifiedWebhookResponse < OpenApiSDK::Utils::FieldAugmented
      extend T::Sig

      # HTTP response content type for this operation
      field :content_type, String
      # HTTP response status code for this operation
      field :status_code, Integer
      # Raw HTTP response; suitable for custom response parsing
      field :raw_response, T.nilable(Faraday::Response)
      # Successful
      field :webhook, T.nilable(Shared::Webhook)


      sig { params(content_type: String, status_code: Integer, raw_response: T.nilable(Faraday::Response), webhook: T.nilable(Shared::Webhook)).void }
      def initialize(content_type: nil, status_code: nil, raw_response: nil, webhook: nil)
        @content_type = content_type
        @status_code = status_code
        @raw_response = raw_response
        @webhook = webhook
      end
    end
  end
end
