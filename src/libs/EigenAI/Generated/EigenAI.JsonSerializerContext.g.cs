
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace EigenAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::EigenAI.JsonConverters.ImageGenerationRequestModeJsonConverter),

            typeof(global::EigenAI.JsonConverters.ImageGenerationRequestModeNullableJsonConverter),

            typeof(global::EigenAI.JsonConverters.ImageEditRequestOutputFormatJsonConverter),

            typeof(global::EigenAI.JsonConverters.ImageEditRequestOutputFormatNullableJsonConverter),

            typeof(global::EigenAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.ImageGenerationRequestMode), TypeInfoPropertyName = "ImageGenerationRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.ImageEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.ImageEditRequestOutputFormat), TypeInfoPropertyName = "ImageEditRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.ImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::EigenAI.Error))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}