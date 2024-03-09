using System.Collections;
using System.Collections.Generic;
using OutputController;

#region Perk Triggers
public class PerkTrigger {
    public string Name { get; set; }
    public string Description { get; set; }

    public PerkTrigger(string name, string description) {
        Name = name;
        Description = description;
    }
}

//The Perk Triggers
public static class PerkTriggers {
    public static PerkTrigger Custom = new PerkTrigger("Custom", "Custom triggers works with specific events.");
    public static PerkTrigger OneTime = new PerkTrigger("One Time", "One time triggers can be used just one time.");
    public static PerkTrigger Hour = new PerkTrigger("Hour", "Triggered for each game hour.");
    public static PerkTrigger Day = new PerkTrigger("Day", "Triggered for each game day.");
    public static PerkTrigger Week = new PerkTrigger("Week", "Triggered for each game week.");
    public static PerkTrigger Month = new PerkTrigger("Month", "Triggered for each game month.");
    public static PerkTrigger Year = new PerkTrigger("Year", "Triggered for each game year.");
}
#endregion

#region Perks
public class PerkBase {
    public string Name { get; set; }
    public string Description { get; set; }
    public byte Cost { get; set; }
    public PerkTrigger Trigger { get; set; }

    public PerkBase()
    {
        Name = "Perk";
        Description = "A perk.";
        Cost = 0;
        Trigger = PerkTriggers.Custom;
    }
}

public class CharacterPerk : PerkBase {
    public CharacterPerk(string name, string description, byte cost, PerkTrigger trigger) {
        Name = name;
        Description = description;
        Cost = cost;
        Trigger = trigger;
    }
}

public class OrganizationPerk : PerkBase {
    public OrganizationPerk(string name, string description, byte cost) {
        Name = name;
        Description = description;
        Cost = cost;
    }
}
#endregion