namespace PDFiumSharp.Types
{
    public interface IHandle<T>
    {
		bool IsNull { get; }

		T SetToNull();
    }
}
