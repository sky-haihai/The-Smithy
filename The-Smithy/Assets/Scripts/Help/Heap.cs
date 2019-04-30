using UnityEngine;
using System.Collections;
using System;

public class Heap<T> where T : IHeapItem<T> {

    T[] items;
    int currentItemCount;

    public Heap(int maxHeapSize) {
        items = new T[maxHeapSize];
    }

    public void Add(T item) {
        item.HeapIndex = currentItemCount;
        items[currentItemCount] = item;
        SortUp(item);
        currentItemCount++;
    }

    public T RemoveFirst() {
        T firstItem = items[0];
        currentItemCount--;
        items[0] = items[currentItemCount];
        items[0].HeapIndex = 0;
        SortDown(items[0]);
        return firstItem;
    }

    public void UpdateItem(T item) {
        SortUp(item);
    }

    public int Count {
        get {
            return currentItemCount;
        }
    }

    public bool Contains(T item) {
        return Equals(items[item.HeapIndex], item);
    }

    void SortDown(T item) {
        while (true) {
            int childIndexLeft = item.HeapIndex * 2 + 1;
            int childIndexRight = item.HeapIndex * 2 + 2;
            int swapIndex = 0;

            if (childIndexLeft < currentItemCount) {
                swapIndex = childIndexLeft;

                if (childIndexRight < currentItemCount) {
                    if (items[childIndexLeft].CompareTo(items[childIndexRight]) < 0) {
                        swapIndex = childIndexRight;
                    }
                }

                if (item.CompareTo(items[swapIndex]) < 0) {
                    Swap(item, items[swapIndex]);
                } else {
                    return;
                }

            } else {
                return;
            }

        }
    }

    void SortUp(T item) {
        int parentIndex = (item.HeapIndex - 1) / 2;

        while (true) {
            T parentItem = items[parentIndex];
            if (item.CompareTo(parentItem) > 0) {
                Swap(item, parentItem);
            } else {
                break;
            }

            parentIndex = (item.HeapIndex - 1) / 2;
        }
    }

    void Swap(T itemA, T itemB) {
        items[itemA.HeapIndex] = itemB;
        items[itemB.HeapIndex] = itemA;
        int itemAIndex = itemA.HeapIndex;
        itemA.HeapIndex = itemB.HeapIndex;
        itemB.HeapIndex = itemAIndex;
    }
}

/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heap<T> where T : IHeapItem<T> {

    public Heap(int size) {
        _items = new T[size];
    }

    public void Add(T item) {
        item.HeapIndex = _currentItemCount;
        _items[_currentItemCount] = item;

        // sort to top
        SortUp(item);

        _currentItemCount++;
    }

    public T GetAndRemoveFirst() {
        T firstItem = _items[0];
        _currentItemCount--;
        _items[0] = _items[_currentItemCount];
        _items[0].HeapIndex = 0;

        // sort to end
        SortDown(_items[0]);

        return firstItem;
    }

    public bool Contains(T item) {
        return Equals(item, _items[item.HeapIndex]);
    }

    public int Count {
        get {
            return _currentItemCount;
        }
    }

    public void UpdateItem(T item) {
        SortUp(item);
    }

    void SortUp(T item) {
        int parentIndex = (item.HeapIndex - 1) / 2;
        while (true) {
            T parentItem = _items[parentIndex];
            //higher priority (lower f cost)
            if (item.CompareTo(parentItem) > 0) {
                Swap(item, parentItem);
                parentIndex = (item.HeapIndex - 1) / 2;
            } else {
                break;
            }
        }
    }

    void SortDown(T item) {
        while (true) {
            int childIndexLeft = item.HeapIndex * 2 + 1;
            int childIndexRight = item.HeapIndex * 2 + 2;

            int swapIndex = 0;

            if (childIndexLeft < _currentItemCount) {
                swapIndex = childIndexLeft;
                if (childIndexRight < _currentItemCount && _items[childIndexLeft].CompareTo(_items[childIndexRight]) < 0) {
                    swapIndex = childIndexRight;
                }

                if (item.CompareTo(_items[swapIndex]) > 0) {
                    Swap(_items[swapIndex], item);
                } else {
                    break;
                }
            } else {
                break;
            }
        }
    }

    void Swap(T itemA, T itemB) {
        _items[itemA.HeapIndex] = itemB;
        _items[itemB.HeapIndex] = itemA;

        int temp = itemA.HeapIndex;
        itemA.HeapIndex = itemB.HeapIndex;
        itemB.HeapIndex = temp;
    }

    T[] _items;
    int _currentItemCount;
}
*/
