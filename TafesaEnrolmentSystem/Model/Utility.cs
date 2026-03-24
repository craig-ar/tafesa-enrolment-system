using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Utility
    {
        /// <summary>
        /// Linear Search: 
        /// Check each element in array to find if any match the target value
        /// Pseudocode:
        ///     SET i to 0
        ///     SET found to false
        ///     WHILE found = false and i < array.Length
        ///         IF array[i] = target 
        ///             SET found to true
        ///         ELSE 
        ///             SET i to i+1
        ///     IF i < array.Length
        ///         RETURN i
        ///     ELSE RETURN -1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            // while not found and not end of array
            while (!found && i < array.Length) 
            {
                // compare target with current element
                if (target.CompareTo(array[i]) == 0)
                    found = true;
                else
                    // if no match move to next element in array
                    i++; 
            }
            if (i < array.Length)
                // return index of array element found
                return i; 
            else
                // return -1 if not found
                return -1; 
        }

        /// <summary>
        /// Binary Search
        /// 
        /// Pseudocode:
        ///     SET min to 0
        ///     SET max to array.Length - 1;
        ///     WHILE min <= max
        ///         SET mid to (min + max) / 2
        ///         If array[mid] is equal to target 
        ///              RETURN mid
        ///         IF array[mid] is less than target 
        ///               SET min = mid + 1
        ///         ELSE
        ///            SET max = mid - 1
        ///     RETURN -1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;
            do
            {
                mid = (min + max) / 2;
                //if the item is found return the index mid
                if (array[mid].CompareTo(target) == 0)  
                    return mid;
                //check if the item wanted is in the top half of the search 
                if (array[mid].CompareTo(target) < 0)
                    //the item must be in the upper half, set the min for the search to start at mid +1    
                    min = mid + 1; 
                else
                    //otherwise the item must be in the lower half, set max to the mid-1
                    max = mid - 1;
            } while (min <= max);
            // -1 is returned when not found
            return -1;  
        }

        /// <summary>
        /// Selection sort ascending
        /// Goes through array to find the smallest item
        /// Swaps this smallest item with the item at index 0 
        /// Goes through the rest of the array to find next smallest item
        /// Swaps this with the item at index 1
        /// Repeatedly swaps next smallest item into next index position until all elements are sorted in ascending order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void SelectionSortAscending<T>(T[] array) where T : IComparable<T>
        {
            T temp; int minIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                        minIndex = j;
                }
                
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;

            }
        }

        /// <summary>
        /// Selection sort decscending
        /// Goes through array to find the largest item
        /// Swaps this largest item with the item at index 0 
        /// Goes through the rest of the array to find next largest item
        /// Swaps this with the item at index 1
        /// Repeatedly swaps next largest item into next index position until all elements are sorted in decscending order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void SelectionSortDescending<T>(T[] array) where T : IComparable<T>
        {
            T temp; int maxIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[maxIndex]) > 0)
                        maxIndex = j;
                }
                
                temp = array[maxIndex];
                array[maxIndex] = array[i];
                array[i] = temp;

            }
        }
    }
}
