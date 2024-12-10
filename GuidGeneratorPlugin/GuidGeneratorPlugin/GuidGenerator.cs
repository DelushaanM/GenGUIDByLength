using System;

namespace GuidGeneratorPlugin
{
    public static class GuidGenerator
    {
        /// <summary>
        /// Generates a GUID string based on the specified length.
        /// </summary>
        /// <param name="length">The desired length of the GUID string.</param>
        /// <returns>A GUID string of the specified length.</returns>
        /// <exception cref="ArgumentException">Thrown when the length is less than 1 or exceeds the maximum allowed length.</exception>
        public static string Generate(int length)
        {
            const int maxLength = 36; // Maximum length of a GUID (including hyphens)
            if (length < 1)
            {
                throw new ArgumentException("Length must be greater than 0.");
            }

            if (length > maxLength)
            {
                throw new ArgumentException($"Length cannot exceed {maxLength}.");
            }

            // Generate a new GUID and remove the hyphens
            string guid = Guid.NewGuid().ToString("N"); // "N" format removes hyphens

            // Return the substring of the desired length
            return guid.Substring(0, length);
        }
    }
}
