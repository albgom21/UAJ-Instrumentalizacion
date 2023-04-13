using System;
using Newtonsoft.Json;

namespace P3
{
    // Clase que representa un evento de nuestro Tracker
    public class TrackerEvent
    {
        public enum EventType      // Tipos de eventos
        {
            INI_SESSION,           // Inicio de la sesión
            END_SESSION,           // Final de la sesión
            ENTER_ROOM,            // Entrada en una sala
            EXIT_ROOM,             // Salida en una sala
            INI_LVL,               // Inicio del nivel
            END_LVL,               // Final del nivel
            PRESS_BUTTON,          // Pulsación de botón del láser
            OPEN_FIRST_DOOR,       // Apertura primera puerta
            POS_PLAYER_ATTACK,     // Posición del jugador cuando se ataque
            POS_PLAYER_INTERACT    // Posición del jugador cuando interactúa
        }
        public enum RoomID         // Nombres de salas ---------METER MAS TIPOS DE ROOMS---------------
        {
            LASER                  //RoomLaser
        }

        // Atributos mínimos que tienen todos los eventos

        protected EventType tipo;  // Tipo de evento

        protected long timestamp;  // Marca de tiempo en POSIX

        // Crear evento
        public TrackerEvent(EventType t)
        {
            timestamp = Tracker.Instance.GetTimeStamp();
            tipo = t;
        }

        // Serializar a JSON
        public string toJSON()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}