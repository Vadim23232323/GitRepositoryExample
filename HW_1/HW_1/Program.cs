using System;
using Collections;
using HW_1.task1_Collections;
using HW_1.task1_GenericCollections;
using HW_1.task2_Dictionary;
using HW_1.task3_LinkedList;


namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = Examples.HashSetShow;

            switch (exampleToRun)
            {
                // task 1 Collections
                case Examples.ArrayListShow:
                    ArrayListExample.ShowArrayList();
                    break;
                case Examples.ArrayListShowTo:
                    ArrayListExample.ShowArrayListTo();
                    break;
                case Examples.StackPush:
                    Stack.PushStack();
                    break;
                case Examples.StackPop:
                    Stack.PopElement();
                    break;
                case Examples.QueueShow:
                    QueueExample.ShowQueue();
                    break;
                case Examples.QueueDelete:
                    QueueExample.DequeueElement();
                    break;
                case Examples.QueuePeek:
                    QueueExample.PeekElement();
                    break;
                case Examples.HashtableShow:
                    HashTableExample.ShowHashTable();
                    break;
                case Examples.HashtablePrintKeys:
                    HashTableExample.PrintKeys();
                    break;
                case Examples.HashtableValueByKey:
                    HashTableExample.GetValueByKey();
                    break;
                case Examples.HashtableDuplicateKeys:
                    HashTableExample.DuplicateKeys();
                    break;
                case Examples.HashtableDuplicateValues:
                    HashTableExample.DuplicateValues();
                    break;
                case Examples.HashtableInitialization:
                    HashTableExample.ConstructorInitialization();
                    break;
                
                // task 1 GenericCollections
                case Examples.ListShow:
                    ListExample.ShowList();
                    break;
                case Examples.ListCompileError:
                    ListExample.CompileError();
                    break;
                case Examples.GenericStackShow:
                    GenericStackExample.ShowGenericStack();
                    break;
                case Examples.GenericStackCompileError:
                    GenericStackExample.CompileError();
                    break;
                case Examples.GenericQueueShow:
                    GenericQueueExample.ShowGenericQueue();
                    break;
                case Examples.GenericQueueCompileError:
                    GenericQueueExample.CompileError();
                    break;
                case Examples.HashSetShow:
                    HashSetExample.ShowHashSet();
                    break;
                case Examples.HashSetContainsRemove:
                    HashSetExample.ContainsAndRemove();
                    break;
                case Examples.HashSetUnion:
                    HashSetExample.UnionSets();
                    break;
                case Examples.HashSetExcept:
                    HashSetExample.ExceptSets();
                    break;
                case Examples.HashSetIntersect:
                    HashSetExample.IntersectSets();
                    break;

                // task 2 Dictionary
                case Examples.DictionaryShow:
                    DictionaryExample.ShowDictionary();
                    break;
                case Examples.DictionaryDelete:
                    DictionaryExample.DeleteDictionary();
                    break;

                // task 3 Linked list
                case Examples.LinkedListShow:
                   LinkedListExample.ShowLinkedList();
                    break;
                case Examples.LinkedListRemoveNode:
                   LinkedListExample.RemoveNode();
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
