using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZedGraph;

namespace STOCKUI2
{
    public class Objective
    {
        public int ObjectiveID;
        public string Priority { get; set; } // 3 - Critical, 2 - Moderate, 1 - Not important
        public string task;
        public string Title;
        public bool Status;
        public DateTime Deadline;

        public Objective()
        { 
        
        
        }

        public int GetObjID()
        {
            return ObjectiveID;
        }
        public string GetStrPriority()
        {
            return Priority;        
        
        }
        public int GetIntPriority()
        {
            return GetImportance(Priority); // Retrieves the integer priority to be used in priority queue method.

        }
        public string GetTask()
        {
            return task;

        }
        public bool GetStatus()
        {
            return Status;

        }

        public DateTime GetDeadline()
        {
            return Convert.ToDateTime(Deadline.ToString("dd/MM/yyyy"));
        }
        public string GetTitle()
        {
            return Title;
        
        }
        // Used to convert string priorities into values. A value of 3 has highest priority and priority 1 has lowest.
        private int GetImportance(string Priority)
        {
            if (Priority == "Not Important")
            {
                return 1;


            }
            else if (Priority == "Moderate")
            {
                return 2;


            }
            else
            {
                return 3;

            }
        }

    }

    internal class ObjectiveList : ObjectiveDB // Again, Inheriting methods from the ObjectiveDB class - separation of front-end and backend 
    {
        private List<Objective> Objectives; // creates a list of objectives - class collection - association


        public ObjectiveList()
        {
            Objectives = new List<Objective>();

        }

        public List<Objective> GetObjectives() // Retrieves Objectives from the Database. 
        {
            return GetObjectivesFromDB();
        
        }
        public List<Objective> ReturnOBJ() // Returns the Objectives after being enqueued to the priority queue and ordered.
        {
            return Objectives;
        }

        public void AddObjective(Objective obj)
        {
            AddObjectiveToDB(obj); // Adds new Objective to database to be ready for retrieval.
        
        }
            
        private bool CompareDates(DateTime t1, DateTime t2) // method used to compare if the date of objective being added is earlier than others - used as a alternative check if priorities of objectives are same.
        {
            if (DateTime.Compare(t1, t2) < 0)
            {
                return true;

            }
            else
            {
                return false;
            
            }
        }
        public void Enqueue(Objective objective) // priority scheduling method
        {
            int placement = 0; // initialises index of comparison to 0 - start of list
            bool OkPosition = false; // Sets postition to false at the start to signify that the objective is not in the correct positon.
            
            while (placement < Objectives.Count && OkPosition == false) // Checks if we have looped through all objectives and the correct position hasn't been reached.
            {
                if (objective.GetIntPriority() > Objectives[placement].GetIntPriority()) // Checks if priority of objective being inserted has a greater priority that objective at index placement - if so, placement has been reached.
                {
                    OkPosition = true;

                }
                else if (objective.GetIntPriority() == Objectives[placement].GetIntPriority()) // Checks if objective being inserted has the same priority of objective at index placement.
                {
                    if (CompareDates(objective.GetDeadline(), Objectives[placement].GetDeadline())) // If the priority is the same, it will then compare the deadlines. If the objective has earlier deadline, placement has reached.
                    {
                        OkPosition = true;

                    }
                    else
                    {
                        placement++; // Increment used to go through whole objective list.
                    
                    }

                }
                else
                {
                    placement++;

                }

            }

            Objectives.Insert(placement, objective); // List operation - Once placement is reached, it will be inserted into the priority queue at that given position.
        }

     

    }
}
