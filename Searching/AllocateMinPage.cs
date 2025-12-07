//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/allocate-minimum-number-of-pages0937
public class Solution
{
    public int FindPages(int[] books, int students)
    {
        if (books == null || books.Length == 0 || students <= 0 || students > books.Length)
            return -1;

        var (maxBook, totalPages) = GetBounds(books);

        int low = maxBook;   // minimum possible maximum pages
        int high = totalPages; // maximum possible maximum pages

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (CanAllocate(books, students, mid))
                high = mid;
            else
                low = mid + 1;
        }

        return low;
    }

    private bool CanAllocate(int[] books, int students, int maxPagesPerStudent)
    {
        int studentCount = 1;
        int currentSum = 0;

        foreach (int pages in books)
        {
            if (currentSum + pages <= maxPagesPerStudent)
                currentSum += pages;
            else
            {
                studentCount++;
                currentSum = pages;
            }
        }

        return studentCount <= students;
    }

    private (int largestBook, int totalPages) GetBounds(int[] books)
    {
        int largest = books[0];
        int total = 0;

        foreach (int pages in books)
        {
            total += pages;
            if (pages > largest)
                largest = pages;
        }

        return (largest, total);
    }
}
