namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интерфейс для произвольного декоратора
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDecorator<T>
    {
        /// <summary>
        /// ссылка на самого себя
        /// </summary>
        T Self { get; set; }
    }
}
