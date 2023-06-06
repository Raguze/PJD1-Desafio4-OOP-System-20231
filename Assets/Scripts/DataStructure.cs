using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructure : MonoBehaviour
{
    private void Awake()
    {
        List<int> list = new List<int>();

        LinkedList<int> linkedList = new LinkedList<int>();
        LinkedListNode<int> first = linkedList.First;
        
        Queue<GameObject> queue = new Queue<GameObject>();
        queue.Enqueue(gameObject);
        GameObject go = queue.Dequeue();

        Stack<MonoBehaviour> stack = new Stack<MonoBehaviour>();
        stack.Push(this);
        MonoBehaviour mb = stack.Pop();

        Dictionary<string, GameObject> dict = new Dictionary<string, GameObject>();
        dict.Add("Enemy1", new GameObject());
        GameObject enemy = dict["Enemy1"];
        dict.Remove("Enemy1");
    }
}
