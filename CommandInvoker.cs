using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    public Queue<ICommand> commands = new Queue<ICommand>();
    public Stack<ICommand> myStack = new Stack<ICommand>();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void AddCommand(ICommand command)
    {
        commands.Enqueue(command);
    }

    public void ProcessAll()
    {
       // while()
      //  {
      //      Process()
      //  }
    }

    public void Process()
    {
        //commands.Enqueue();
    }

    public void Undo()
    {
        if (commands != null)
        {

        }
    }
}

