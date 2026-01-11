public static class ListExtensions
{
	public static T Pop<T>(this List<T> list, int index = -1)
	{
		if (list.Count == 0) throw new InvalidOperationException("List is empty.");

		if (index == -1)
            index = list.Count - 1;

        if (index < 0 || index >= list.Count) throw new ArgumentOutOfRangeException(nameof(index));

		T value = list[index];
		list.RemoveAt(index);
		return value;
	}
}