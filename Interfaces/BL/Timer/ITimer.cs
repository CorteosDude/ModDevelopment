using System;

namespace JavelinBL2.Interfaces.Timer
{
    /// <summary>
    /// интерфейс для реализации контроллеров действий, выполняемых по таймеру
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// Название выполняемого действия - по нему контроллер будет выбираться со вьюхе при вызове с апи
        /// </summary>
        string ActionType { get; }

        /// <summary>
        /// Метод, который реализует таймер.
        /// </summary>
        /// <param name="id">Идентификатор заказа или командировки, по которым выполняется действие</param>
        void Proceed(int id);

        /// <summary>
        /// делаем доступным метод логгирования эксепшна для обработки действия таймера через экстеншн
        /// </summary>
        /// <param name="ex"></param>
        void Log(Exception ex);

        /// <summary>
        /// Доступ к методу логгирования
        /// </summary>
        /// <param name="str"></param>
        void Log(string str);
    }
}