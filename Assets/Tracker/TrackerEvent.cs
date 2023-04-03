using System;

public class TrackerEvent
{
    public enum EventType
    {

        INI_SESSION,           //Inicio de la sesión
        END_SESSION,           //Final de la sesión
        ENTER_ROOM,            //Entrada en una sala
        EXIT_ROOM,             //Salida en una sala
        INI_LVL,               //Inicio del nivel
        END_LVL,               //Final del nivel
        PRESS_BUTTON,          //Pulsación de botón del láser
        OPEN_FIRST_DOOR,       //Apertura primera puerta
        POS_PLAYER_ATTACK,     //Posición del jugador cuando se ataque
        POS_PLAYER_INTERACT    //Posición del jugador cuando interactúa
    }
    public enum RoomID
    {
        LASER                  //RoomLaser
    }

    protected EventType tipo;
    protected long timestamp;

    public TrackerEvent() {
        
    }
    public TrackerEvent(EventType t)
    {
        // Obtener la fecha y hora actual
        DateTimeOffset now = DateTimeOffset.Now;
        // Convertir la fecha y hora a un timestamp de tiempo POSIX
        timestamp = now.ToUnixTimeSeconds();

        tipo = t;
    }
}