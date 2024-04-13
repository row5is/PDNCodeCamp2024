using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeRunLeaders.Model
{
    public class Player
    {
        public string _ref { get; set; }
        public string id { get; set; }
        public string uid { get; set; }
        public string guid { get; set; }
        public string type { get; set; }
        public Alternateids alternateIds { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string displayName { get; set; }
        public string nickname { get; set; }
        public string shortName { get; set; }
        //public int weight { get; set; }
        public string displayWeight { get; set; }
        //public int height { get; set; }
        public string displayHeight { get; set; }
        public int age { get; set; }
        public string dateOfBirth { get; set; }
        public int debutYear { get; set; }
        public Link[] links { get; set; }
        public Birthplace birthPlace { get; set; }
        public string slug { get; set; }
        public Headshot headshot { get; set; }
        public string jersey { get; set; }
        public Position position { get; set; }
        public Position1[] positions { get; set; }
        public object[] injuries { get; set; }
        public bool linked { get; set; }
        public Team team { get; set; }
        public Team1[] teams { get; set; }
        public Statistics statistics { get; set; }
        public Projections projections { get; set; }
        public Notes notes { get; set; }
        public Contracts contracts { get; set; }
        //public Hotzone[] hotZones { get; set; }
        public Experience experience { get; set; }
        public Debut debut { get; set; }
        public bool active { get; set; }
        public Eventlog eventLog { get; set; }
        public Status status { get; set; }
        public Bats bats { get; set; }
        public Throws throws { get; set; }
    }

    public class Alternateids
    {
        public string sdr { get; set; }
    }

    public class Birthplace
    {
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Headshot
    {
        public string href { get; set; }
        public string alt { get; set; }
    }

    public class Position
    {
        public string _ref { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string abbreviation { get; set; }
        public bool leaf { get; set; }
        public Parent parent { get; set; }
    }

    public class Parent
    {
        public string _ref { get; set; }
    }

    public class Projections
    {
        public string _ref { get; set; }
    }

    public class Notes
    {
        public string _ref { get; set; }
    }

    public class Contracts
    {
        public string _ref { get; set; }
    }

    public class Experience
    {
        public int years { get; set; }
    }

    public class Debut
    {
        public int year { get; set; }
        public Event _event { get; set; }
        public Statistics1 statistics { get; set; }
    }

    public class Event
    {
        public string _ref { get; set; }
    }

    public class Statistics1
    {
        public string _ref { get; set; }
    }

    public class Eventlog
    {
        public string _ref { get; set; }
    }

    public class Status
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Bats
    {
        public string type { get; set; }
        public string abbreviation { get; set; }
        public string displayValue { get; set; }
    }

    public class Throws
    {
        public string type { get; set; }
        public string abbreviation { get; set; }
        public string displayValue { get; set; }
    }

    public class Link
    {
        public string language { get; set; }
        public string[] rel { get; set; }
        public string href { get; set; }
        public string text { get; set; }
        public string shortText { get; set; }
        public bool isExternal { get; set; }
        public bool isPremium { get; set; }
    }

    public class Position1
    {
        public string _ref { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string abbreviation { get; set; }
        public bool leaf { get; set; }
        public Parent1 parent { get; set; }
        public Statistics2 statistics { get; set; }
    }

    public class Parent1
    {
        public string _ref { get; set; }
    }

    public class Statistics2
    {
        public string _ref { get; set; }
    }

    public class Team1
    {
        public string _ref { get; set; }
    }

    public class Hotzone
    {
        public int configurationId { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public int splitTypeId { get; set; }
        public int season { get; set; }
        public int seasonType { get; set; }
        public Zone[] zones { get; set; }
    }

    public class Zone
    {
        public int zoneId { get; set; }
        public int xMin { get; set; }
        public int xMax { get; set; }
        public int yMin { get; set; }
        public int yMax { get; set; }
        public int atBats { get; set; }
        public int hits { get; set; }
        public float battingAvg { get; set; }
        public float battingAvgScore { get; set; }
        public float slugging { get; set; }
        public float sluggingScore { get; set; }
    }


}
