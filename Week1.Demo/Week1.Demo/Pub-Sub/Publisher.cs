using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Demo.Pub_Sub
{
    public class Publisher
    {
        // Campi
        public string PublisherName { get; set; }

        // Costruttore
        public Publisher(string publisherName)
        {
            PublisherName = publisherName;
        }

        // Delegate
        public delegate void Notify(Publisher p, Notification n);
        // Evento
        public event Notify OnPublish;

        // Metodo che pubblica l'evento
        public void Publish()
        {
            if (OnPublish != null)
            {
                Notification notification = new Notification("New notification from ", DateTime.Now);
                OnPublish(this, notification);
            }
        }
    }
}
