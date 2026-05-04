
#nullable enable

namespace EigenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        ImageEditing,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestMode value)
        {
            return value switch
            {
                ImageGenerationRequestMode.ImageEditing => "image-editing",
                ImageGenerationRequestMode.TextToImage => "text-to-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "image-editing" => ImageGenerationRequestMode.ImageEditing,
                "text-to-image" => ImageGenerationRequestMode.TextToImage,
                _ => null,
            };
        }
    }
}