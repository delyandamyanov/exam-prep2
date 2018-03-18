
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, Dictionary<string, List<string>>> events = new Dictionary<int, Dictionary<string, List<string>>>();
            
            while(!string.Join(" ", input).Equals("Time for Code"))
            {
                int ID = int.Parse(input[0]);
                string eventName = input[1];

                if (!eventName[0].Equals('#')) //corrent input check
                {
                    input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                List<string> participants = input.Skip(2).ToList();

                
                foreach(var participant in participants) //corrent input check
                {
                    if (!participant[0].Equals('@'))
                    {
                        participants.Remove(participant);
                    }
                }

                if (!events.ContainsKey(ID))
                {
                    events[ID] = new Dictionary<string, List<string>>();
                    events[ID][eventName] = participants;
                }
                else
                {
                    if (!events[ID].ContainsKey(eventName))
                    {
                        events[ID].Add(eventName, participants);
                    }
                    else
                    {
                        events[ID][eventName].InsertRange(events[ID][eventName].Count(), participants);
                        events[ID][eventName] = events[ID][eventName].Distinct().ToList();
                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            
            foreach(var Event in events)
            {
                foreach(var eventDict in Event.Value)
                {
                    Console.WriteLine($"{eventDict.Key} - {eventDict.Value.Count}");
                    foreach(var particip in eventDict.Key)
                    {

                    }
                }
            }
            
        }
    }

    class Event
    {
        public string EventName { get; set; }
        public List<string> Participants { get; set; }

        public Event(string EventName, List<string> Participants)
        {
            this.EventName = EventName;
            this.Participants = Participants;
        }
    }
}
