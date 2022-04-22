﻿namespace portfolio_project.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string  Image { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }

        public Project(long id, string name, string description, string image, string client)
        {
            Id= id;
            Name= name;
            Image= image;
            Client= client;
            Description= description;

        }
    }
}
