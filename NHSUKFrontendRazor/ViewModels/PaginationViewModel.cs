namespace NHSUKFrontendRazor.ViewModels
{
    public class PaginationViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationViewModel"/> class.
        /// </summary>
        public PaginationViewModel() { }

        /// <summary>
        ///  Initializes a new instance of the <see cref="PaginationViewModel"/> class.
        /// </summary>
        /// <param name="currentPage">Current page index.</param>
        /// <param name="totalPage">Total page index.</param>
        /// <param name="prevUrl">Previous page url.</param>
        /// <param name="nextUrl">Next page url.</param>
        public PaginationViewModel(string currentPage, string totalPage, string prevUrl, string nextUrl)
        {
            IsAlphabetic = PaginationSequence.IsLetter(currentPage) || PaginationSequence.IsLetter(totalPage);
            CurrentIndex = PaginationSequence.ToIndex(currentPage);
            TotalIndex = PaginationSequence.ToIndex(totalPage);
            PreviousUrl = prevUrl;
            NextUrl = nextUrl;
        }

        public bool IsAlphabetic { get; set; }
        public int CurrentIndex { get; set; }
        public int TotalIndex { get; set; }
        public string PreviousUrl { get; set; }
        public string NextUrl { get; set; }

        public bool HasPrevious => CurrentIndex > 1;
        public bool HasNext => CurrentIndex < TotalIndex;

        public string PreviousSequence => PaginationSequence.ToSequence(CurrentIndex - 1, IsAlphabetic);
        public string NextSequence => PaginationSequence.ToSequence(CurrentIndex + 1, IsAlphabetic);
        public string TotalSequence => PaginationSequence.ToSequence(TotalIndex, IsAlphabetic);
    }

    public static class PaginationSequence
    {
        public static bool IsLetter(string value) =>
            !string.IsNullOrWhiteSpace(value) && value.Trim().All(char.IsLetter);

        public static int ToIndex(string value)
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