namespace NHSUKFrontendRazor.ViewModels
{
    using System.Linq;

    /// <summary>
    /// View model for the pagination component.
    /// </summary>
    public class PaginationViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationViewModel"/> class.
        /// </summary>
        public PaginationViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationViewModel"/> class.
        /// </summary>
        /// <param name="currentPage">Current page or sequence identifier.</param>
        /// <param name="totalPage">Total pages or total sequence identifier.</param>
        /// <param name="prevUrl">Previous page URL.</param>
        /// <param name="nextUrl">Next page URL.</param>
        /// <param name="previousSequence">Optional override for the previous sequence display text.</param>
        /// <param name="nextSequence">Optional override for the next sequence display text.</param>
        public PaginationViewModel(
            string currentPage,
            string totalPage,
            string? prevUrl,
            string? nextUrl,
            string? previousSequence = null,
            string? nextSequence = null)
        {
            IsAlphabetic = PaginationSequence.IsLetter(currentPage) || PaginationSequence.IsLetter(totalPage);
            CurrentIndex = PaginationSequence.ToIndex(currentPage);
            TotalIndex = PaginationSequence.ToIndex(totalPage);
            PreviousUrl = prevUrl;
            NextUrl = nextUrl;

            PreviousSequence = !string.IsNullOrEmpty(previousSequence)
                ? previousSequence
                : PaginationSequence.ToSequence(CurrentIndex - 1, IsAlphabetic);

            NextSequence = !string.IsNullOrEmpty(nextSequence)
                ? nextSequence
                : PaginationSequence.ToSequence(CurrentIndex + 1, IsAlphabetic);

            TotalSequence = PaginationSequence.ToSequence(TotalIndex, IsAlphabetic);
        }

        /// <summary>
        /// Gets or sets a value indicating whether pagination is alphabetic.
        /// </summary>
        public bool IsAlphabetic { get; set; }

        /// <summary>
        /// Gets or sets the 1-based current page index.
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>
        /// Gets or sets the total page index.
        /// </summary>
        public int TotalIndex { get; set; }

        /// <summary>
        /// Gets or sets the previous page URL.
        /// </summary>
        public string? PreviousUrl { get; set; }

        /// <summary>
        /// Gets or sets the next page URL.
        /// </summary>
        public string? NextUrl { get; set; }

        /// <summary>
        /// Gets a value indicating whether a previous page exists.
        /// </summary>
        public bool HasPrevious => !string.IsNullOrEmpty(PreviousUrl) && (CurrentIndex > 1 || !string.IsNullOrEmpty(PreviousSequence));

        /// <summary>
        /// Gets a value indicating whether a next page exists.
        /// </summary>
        public bool HasNext => !string.IsNullOrEmpty(NextUrl) && (CurrentIndex < TotalIndex || !string.IsNullOrEmpty(NextSequence));

        /// <summary>
        /// Gets or sets the sequence display text for the previous page.
        /// </summary>
        public string? PreviousSequence { get; set; }

        /// <summary>
        /// Gets or sets the sequence display text for the next page.
        /// </summary>
        public string? NextSequence { get; set; }

        /// <summary>
        /// Gets or sets the sequence display text for the total pages.
        /// </summary>
        public string? TotalSequence { get; set; }
    }

    /// <summary>
    /// Helper utilities for pagination sequences.
    /// </summary>
    public static class PaginationSequence
    {
        /// <summary>
        /// Determines whether the specified string value consists exclusively of alphabetic letters.
        /// </summary>
        /// <param name="value">The string value to check.</param>
        /// <returns><c>true</c> if the string is non-empty and consists only of letters; otherwise, <c>false</c>.</returns>
        public static bool IsLetter(string? value) =>
            !string.IsNullOrWhiteSpace(value) && value.Trim().All(char.IsLetter);

        /// <summary>
        /// Converts a string sequence representation (numeric or alphabetic) to a 1-based index.
        /// </summary>
        /// <param name="value">The sequence string (e.g., "1", "A", "AA").</param>
        /// <returns>The 1-based index value, or 0 if invalid or empty.</returns>
        public static int ToIndex(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            value = value.Trim();

            if (int.TryParse(value, out var number))
            {
                return number;
            }

            var result = 0;
            foreach (var c in value.ToUpperInvariant())
            {
                if (c < 'A' || c > 'Z')
                {
                    return 0;
                }

                result = result * 26 + (c - 'A' + 1);
            }

            return result;
        }

        /// <summary>
        /// Converts a 1-based index to its string sequence representation (numeric or alphabetic).
        /// </summary>
        /// <param name="index">The 1-based index.</param>
        /// <param name="alphabetic">Whether to format as an alphabetic sequence.</param>
        /// <returns>The sequence string representation.</returns>
        public static string ToSequence(int index, bool alphabetic)
        {
            if (index < 1)
            {
                return string.Empty;
            }

            if (!alphabetic)
            {
                return index.ToString();
            }

            var sequence = string.Empty;
            while (index > 0)
            {
                index--;
                sequence = (char)('A' + index % 26) + sequence;
            }

            return sequence;
        }
    }
}