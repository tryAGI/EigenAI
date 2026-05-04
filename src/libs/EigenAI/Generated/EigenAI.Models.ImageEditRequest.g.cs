
#nullable enable

namespace EigenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageEditRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_path")]
        public string? ImagePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public double? NumInferenceSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary_response")]
        public bool? BinaryResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::EigenAI.JsonConverters.ImageEditRequestOutputFormatJsonConverter))]
        public global::EigenAI.ImageEditRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downsizing_mp")]
        public double? DownsizingMp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_strength")]
        public double? LoraStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public double? Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offloading")]
        public bool? Offloading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public string? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true_cfg_scale")]
        public double? TrueCfgScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_steps")]
        public double? SampleSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_guide_scale")]
        public double? SampleGuideScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_output_path")]
        public string? S3OutputPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="imagePath"></param>
        /// <param name="numInferenceSteps"></param>
        /// <param name="binaryResponse"></param>
        /// <param name="outputFormat"></param>
        /// <param name="downsizingMp"></param>
        /// <param name="loraStrength"></param>
        /// <param name="rank"></param>
        /// <param name="offloading"></param>
        /// <param name="weight"></param>
        /// <param name="trueCfgScale"></param>
        /// <param name="sampleSteps"></param>
        /// <param name="sampleGuideScale"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="s3OutputPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEditRequest(
            string model,
            string prompt,
            byte[]? imageFile,
            string? imageFilename,
            byte[]? image,
            string? imagename,
            string? imagePath,
            double? numInferenceSteps,
            bool? binaryResponse,
            global::EigenAI.ImageEditRequestOutputFormat? outputFormat,
            double? downsizingMp,
            double? loraStrength,
            double? rank,
            bool? offloading,
            string? weight,
            double? trueCfgScale,
            double? sampleSteps,
            double? sampleGuideScale,
            string? negativePrompt,
            string? s3OutputPath)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.Image = image;
            this.Imagename = imagename;
            this.ImagePath = imagePath;
            this.NumInferenceSteps = numInferenceSteps;
            this.BinaryResponse = binaryResponse;
            this.OutputFormat = outputFormat;
            this.DownsizingMp = downsizingMp;
            this.LoraStrength = loraStrength;
            this.Rank = rank;
            this.Offloading = offloading;
            this.Weight = weight;
            this.TrueCfgScale = trueCfgScale;
            this.SampleSteps = sampleSteps;
            this.SampleGuideScale = sampleGuideScale;
            this.NegativePrompt = negativePrompt;
            this.S3OutputPath = s3OutputPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditRequest" /> class.
        /// </summary>
        public ImageEditRequest()
        {
        }
    }
}