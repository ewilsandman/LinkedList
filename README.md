# Linked List

- [x] De klasser som ska finnas är:
- [x] MyLinkedList<T>
- [x] Node<T>
- [x] Program (endast för att ha en tom Main-metod)
  
Vi kommer att använda dessa namn för att undvika konflikter med de klasser som finns i System.Collections.Generic. 
Metoder

Det inlämnade programmet ska ha följande metoder implementerade:

- [x] AddFirst(T)
- [x] AddLast(T)
- [x] Clear()
- [x] Contains(T)
- [x] Find(T)
- [x] Remove(Node T)
- [x] Remove(T)
- [x] GetEnumerator() (Se nedan i Iteration och index)

Utöver ovanstående metoder ska listan ha stöd för följande:

- [x]Count: Listan skall hålla koll på hur många element som finns i listan.
- [x]Index: Man skall kunna komma åt specifika element i listan genom [int index]. 
- [x]Stöd för foreach: Det skall gå att iterera över listan med foreach-loopar. Detta kräver att IEnumerable implementeras.
