namespace LostTech.Tasks
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public static class TaskZ
    {
        public static async Task<ValueTuple<T1, T2>> Parallel<T1, T2>(Task<T1> task1, Task<T2> task2)
        {
            await Task.WhenAll(task1, task2).ConfigureAwait(false);
            return (task1.Result, task2.Result);
        }
        public static async Task<ValueTuple<T1, T2, T3>> Parallel<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
        {
            await Task.WhenAll(task1, task2, task3).ConfigureAwait(false);
            return (task1.Result, task2.Result, task3.Result);
        }
        public static async Task<ValueTuple<T1, T2, T3, T4>> Parallel<T1, T2, T3, T4>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
        {
            await Task.WhenAll(task1, task2, task3, task4).ConfigureAwait(false);
            return (task1.Result, task2.Result, task3.Result, task4.Result);
        }
        public static async Task<ValueTuple<T1, T2, T3, T4, T5>> Parallel<T1, T2, T3, T4, T5>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
        {
            await Task.WhenAll(task1, task2, task3, task4, task5).ConfigureAwait(false);
            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result);
        }

        /// <summary>
        /// Shorthand for .ConfigureAwait(false);
        /// </summary>
        /// <typeparam name="T">Task result type</typeparam>
        /// <param name="task">Task to configure</param>
        public static ConfiguredTaskAwaitable<T> NoSync<T>(this Task<T> task) => task.ConfigureAwait(false);
    }
}
