#nullable enable

namespace EigenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageEditRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::EigenAI.ImageEditRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::EigenAI.ImageEditRequestOutputFormat Read(
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
                        return global::EigenAI.ImageEditRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::EigenAI.ImageEditRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::EigenAI.ImageEditRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::EigenAI.ImageEditRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::EigenAI.ImageEditRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
