public class Tracker
{
    private static Tracker instance = null;
    // persistenceObject IPersistence



    // Constructor privado para evitar la creación de instancias fuera de la clase
    private Tracker() { }

    // Método para obtener la instancia única del Singleton
    public static Tracker Instance
    {
        get
        {
            if (instance == null)
                instance = new Tracker();

            return instance;
        }
    }

    // Método para inicializar la instancia única del Singleton
    public bool Init()
    {
        if (instance == null)
            instance = new Tracker();

        if (instance == null)
            return false;

        return true;
    }

    // Método para finalizar la instancia única del Singleton
    public void End()
    {
        instance = null;
    }

    public void TrackEvent()
    {

    }
}