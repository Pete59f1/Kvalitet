using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Control
    {
        DBControl dbc;
        public Control()
        {
            dbc = new DBControl();

        }
        public event EventHandler<Exception> eventHandler;
        public void NotifyObservers(Exception e)
        {
            if (eventHandler != null)   //Ensures that if there are no handlers,
                                        //the event won't be raised
            {
                eventHandler(this, e);    //We can also replace
                                          //EventArgs.Empty with our own message
            }
        }
        public void Subscribe()
        {
            dbc.eventHandler += ExceptionSender;
        }

        private void ExceptionSender(Object sender, Exception e)
        {
            NotifyObservers(e);
        }
        public void CreateCustomer(string name, string address, int zip, string town, string tlf)
        {
            
            dbc.CreateCustomer(name, address, zip, town, tlf);
        }
        public string FindCustomer(int id)
        {
            
        }
    }
}
