using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
            LASER,                  //RoomLaser
            PASILLO
        }

        // Atributos mínimos que tienen todos los eventos

        public EventType tipo;  // Tipo de evento

        public long timestamp;  // Marca de tiempo en POSIX


        // Permitir que los enumerados se persistan con su nombre en lugar de su valor entero
        static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };

        // Crear evento
        public TrackerEvent(EventType t)
        {
            timestamp = Tracker.Instance.GetTimeStamp();
            tipo = t;
        }

        // Serializar a JSON
        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this, settings);
        }
    }
}