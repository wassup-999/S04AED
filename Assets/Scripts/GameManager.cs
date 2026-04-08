using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    //public LinkedList<string> ListaDeNombres = new();
    public List<string> Inputs = new List<string>();
    public Enemy enemyPref;

    public CustomLinkedList HordaManagment;


    public List<NodeOfHorde> Nodes;
    public DoubleLinkedList<string> Nombres ;
    public CircularDoubleLinkedList<string> Dialogs;
    void Start()
    {
        foreach(var input in Inputs)
        {
            Nombres.Add(input);
            Dialogs.Add(input);
        }
        HordaManagment.Set(enemyPref);

        //HordaManagment.ad
        foreach (var horde in Nodes)
        {
            HordaManagment.Add(horde);
        }

        print(HordaManagment.Count);
    }
    void Update()
    {

    }
    [Button]
    public void ShowDoubleList()
    {
        Nombres.TraverseInOrder(value => Debug.Log(value.Value));
        
    }
    [Button]
    public void RemoveFirst()
    {
        Dialogs.RemoveFirst();
    }
    [Button]
    public void RemoveLast()
    {
        Dialogs.RemoveLast();
    }
    [Button]
    public void AddCustom(string Value)
    {
        Dialogs.Add(Value);
    }


    /*
    [Button]
    public void TestMethod(string name, int value)
    {
        Debug.Log("Eureka");
    }


    [Button]
    public void TestNodes()
    {
        Node<string> a = new("juan");
        Node<string> b = new("juan2");
        Node<string> c = new("juan3");
        Node<string> d = new("juan4");
        Node<string> e = new("juan5");
        a.SetNext(b);
        b.SetNext(c);
        c.SetNext(d);
        d.SetNext(e);

        Node<string> Evaluator = a;
        while (Evaluator != null)
        {
            Debug.Log(Evaluator.Value);
            Evaluator = Evaluator.Next;
        }
    }

    [Button]
    public void TestLinkedList(List<string> ListaNombres)
    {
        LinkedList<string> ListaDeNombres = new();
        foreach (string n in ListaNombres)
        {
            ListaDeNombres.Add(n);
        }
        Debug.Log(ListaDeNombres.Count);
        //ListaDeNombres.RemoveFirst();
        ListaDeNombres.RemoveLast();

        ListaDeNombres.Traverse(value => Debug.Log(value.Value));

    }

    [Button]
    public void HordeSpawnTest()
    {
        //NodeOfHorde hordaA = new();
        HordaManagment.SpawnHorde();
    }
    */
}