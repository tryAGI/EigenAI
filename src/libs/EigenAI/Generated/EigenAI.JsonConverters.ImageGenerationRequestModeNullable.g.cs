#nullable enable

namespace EigenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageGenerationRequestModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::EigenAI.ImageGenerationRequestMode?>
    {
        /// <inheritdoc />
        public override global::EigenAI.ImageGenerationRequestMode? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::EigenAI.ImageGenerationRequestModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::EigenAI.ImageGenerationRequestMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::EigenAI.ImageGenerationRequestMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::EigenAI.ImageGenerationRequestMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::EigenAI.ImageGenerationRequestModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
