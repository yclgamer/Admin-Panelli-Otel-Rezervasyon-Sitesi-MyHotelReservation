﻿namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class GetMessageByIdDto
    {
        public int ContactID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public string? Date { get; set; }
    }
}
