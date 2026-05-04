#nullable enable

namespace EigenAI
{
    public partial interface IEigenAIClient
    {
        /// <summary>
        /// Generate or edit an image.<br/>
        /// Generates images from text prompts with JSON requests, or edits images with multipart form uploads depending on the selected model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::EigenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::EigenAI.ImageGenerationResponse> GenerateImageAsync(

            global::EigenAI.ImageGenerationRequest request,
            global::EigenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or edit an image.<br/>
        /// Generates images from text prompts with JSON requests, or edits images with multipart form uploads depending on the selected model.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::EigenAI.ImageGenerationResponse> GenerateImageAsync(
            string model,
            string prompt,
            int? seed = default,
            global::EigenAI.ImageGenerationRequestMode? mode = default,
            bool? realTime = default,
            int? width = default,
            int? height = default,
            double? guidanceScale = default,
            global::EigenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}