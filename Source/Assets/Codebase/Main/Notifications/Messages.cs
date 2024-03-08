using UnityEngine;
using System.Collections.Generic;
using OutputController;

public class MessageTypes
{
    public const string RawMessage = "Raw Message";
    public const string JobOffer = "Job Offer";
    public const string AssociationOffer = "Association Offer";
    public const string CouncilChairOffer = "Council Chair Offer";
}

public class GameMessageScript : MonoBehaviour
{
    public static List<Message> AllMessages = new List<Message>();

    public static void NewMessage(string content, string messageType, Player authorPl, NPC authorNPC, List<Player> destinationPl, List<NPC> destinationNPC)
    {
        Message message = new Message();
        message.Content = content;
        message.MessageType = messageType;
        message.AuthorPlayer = authorPl;
        message.AuthorNPC = authorNPC;
        message.DestinationPlayer = destinationPl;
        message.DestinationNPC = destinationNPC;
    }

    public static void Notification(string content, List<Player> destinationPl, Color color, bool subNotification)
    {
        if (!destinationPl.Contains(null))
        {
            Notification notification = new Notification();
            notification.Content = content;
            notification.DestinationPlayer = destinationPl;
            notification.Color = color;
            notification.IsSubNotification = subNotification;
        }
    }
}

#region Classes
public class MessageBase
{
    public string Content { get; set; }

    public MessageBase()
    {
        Content = "";
    }
}

public class Message : MessageBase
{
    public string MessageType = "";

    public Player AuthorPlayer { get; set; }
    public NPC AuthorNPC { get; set; }

    public List<Player> DestinationPlayer { get; set; }
    public List<NPC> DestinationNPC { get; set; }

    public Message()
    {
        AuthorPlayer = null;
        AuthorNPC = null;

        DestinationPlayer = new List<Player>();
        DestinationNPC = new List<NPC>();
    }
}
public class Notification : MessageBase
{
    public List<Player> DestinationPlayer { get; set; }
    public Color Color { get; set; }
    public bool IsSubNotification { get; set; }

    public Notification()
    {
        DestinationPlayer = new List<Player>();
        Color = Color.white;
        IsSubNotification = false;
    }
}
#endregion
