using System;
using System.Windows;

namespace Lab3
{
    static class PersonAdapter
    {
        internal static Person CreatePerson(string name, string lastName, string email, DateTime dateOfBirth)
        {
            try
            {
                return new Person(name, lastName, email, dateOfBirth);
            }
            catch (FutureDateOfBirthException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            catch(OldDateOfBirthException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            catch(WrongEmailAdressException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
          
                return null;
        }
    }
}
