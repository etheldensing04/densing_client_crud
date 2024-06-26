﻿
using densing_client_crud.Entities;
using densing_client_crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace complete_csharp_crud
{
    internal class DatabaseOperation
    {
        private readonly densingdbEntities _context = new densingdbEntities();
        private readonly BindingSource _bindingSource;

        public DatabaseOperation() { }

        public DatabaseOperation(BindingSource _bindingSource)
        {
            this._bindingSource = _bindingSource;
        }

        public densingdbEntities _con
        {
            get
            {
                return _context;
            }
        }

        public void addClient()
        {
            AddClient _addClient = new AddClient();
            _addClient.ShowDialog();

            string fname = _addClient.GetAddText[0];
            string lname = _addClient.GetAddText[1];
            string residency = _addClient.GetAddText[2];
            DateTime date = _addClient.dateValue;                 

            Client add_client = new Client();

            add_client.Firstname = fname;
            add_client.Lastname = lname;
            add_client.Residency = residency;
            add_client.Birthday = date;

            _context.Clients.Add(add_client);
            _context.SaveChanges();

            _bindingSource.DataSource = _context.Clients.ToList();
        }

        public void updateClients(int _id)
        {
            UpdateClient updateCLient = new UpdateClient(_id);
            updateCLient.ShowDialog();

            string fname = updateCLient.GetAddText[0];
            string lname = updateCLient.GetAddText[1];
            string residency = updateCLient.GetAddText[2];
            DateTime date = updateCLient.dateValue;

            var selectedClient = _context.Clients.Where(q => q.Id == _id).FirstOrDefault();

            selectedClient.Firstname = fname;
            selectedClient.Lastname = lname;
            selectedClient.Residency = residency;
            selectedClient.Birthday = date;

            _context.SaveChanges();

            _bindingSource.DataSource = _context.Clients.ToList();
        }

        public void deleteClients(int _id)
        {
            var itemToDelete = _context.Clients.Where(q => q.Id == _id).FirstOrDefault();

            _context.Clients.Remove(itemToDelete);
            _context.SaveChanges();

            _bindingSource.DataSource = _context.Clients.ToList();
        }

        public void searchClient(string text)
        {
            try
            {
                int id;
                bool isId = int.TryParse(text, out id);

                var result = _context.Clients
                    .Where(c => (isId && c.Id == id) ||
                                c.Firstname.Contains(text) ||
                                c.Lastname.Contains(text) ||
                                c.Residency.Contains(text))
                    .Select(c => new
                    {
                        c.Id,
                        c.Firstname,
                        c.Lastname,
                        c.Residency,
                        c.Birthday
                    })
                    .ToList();

                _bindingSource.DataSource = result;
            }
            catch (Exception ex)
            {
            }
        }
    }
}