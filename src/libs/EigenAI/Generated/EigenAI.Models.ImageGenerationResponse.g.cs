
#nullable enable

namespace EigenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_base64")]
        public string? ImageBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        /// <param name="imageBase64"></param>
        /// <param name="imageUrl"></param>
        /// <param name="url"></param>
        /// <param name="output"></param>
        /// <param name="status"></param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponse(
            string? imageBase64,
            string? imageUrl,
            string? url,
            string? output,
            string? status,
            string? requestId)
        {
            this.ImageBase64 = imageBase64;
            this.ImageUrl = imageUrl;
            this.Url = url;
            this.Output = output;
            this.Status = status;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        public ImageGenerationResponse()
        {
        }

    }
}