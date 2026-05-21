
#nullable enable

namespace EigenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Model ID selected from the EigenAI model library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Text prompt describing what to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EigenAI.JsonConverters.ImageGenerationRequestModeJsonConverter))]
        public global::EigenAI.ImageGenerationRequestMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("real_time")]
        public bool? RealTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID selected from the EigenAI model library.
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing what to generate.
        /// </param>
        /// <param name="seed"></param>
        /// <param name="mode"></param>
        /// <param name="realTime"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="guidanceScale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            string model,
            string prompt,
            int? seed,
            global::EigenAI.ImageGenerationRequestMode? mode,
            bool? realTime,
            int? width,
            int? height,
            double? guidanceScale)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Seed = seed;
            this.Mode = mode;
            this.RealTime = realTime;
            this.Width = width;
            this.Height = height;
            this.GuidanceScale = guidanceScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }

    }
}