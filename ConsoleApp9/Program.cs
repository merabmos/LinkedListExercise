
using ConsoleApp9.LinkedList;



SimpleLinkedList<string> simpleLinkedList = new SimpleLinkedList<string>();
simpleLinkedList.AddFirst("Me");
simpleLinkedList.AddLast("Ra");
simpleLinkedList.AddLast("Bi");

simpleLinkedList.RemoveFirst();
simpleLinkedList.RemoveFirst();
simpleLinkedList.RemoveFirst();
simpleLinkedList.RemoveFirst();
simpleLinkedList.AddLast("Bi");
simpleLinkedList.AddLast("Bi");



simpleLinkedList.ReadAll();
