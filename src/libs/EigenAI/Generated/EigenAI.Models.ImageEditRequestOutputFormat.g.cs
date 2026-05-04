
#nullable enable

namespace EigenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageEditRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditRequestOutputFormat value)
        {
            return value switch
            {
                ImageEditRequestOutputFormat.Jpg => "jpg",
                ImageEditRequestOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpg" => ImageEditRequestOutputFormat.Jpg,
                "png" => ImageEditRequestOutputFormat.Png,
                _ => null,
            };
        }
    }
}