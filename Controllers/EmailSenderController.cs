using Microsoft.AspNetCore.Mvc;
using Portfolio.Misc;
using Portfolio.Models;

namespace Portfolio.Controllers;

public class EmailSenderController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    private readonly IEmailSender _emailSender;
    private readonly EmailConfiguration _emailConfig;

    public EmailSenderController(IEmailSender emailSender, EmailConfiguration emailConfig)
    {
        _emailSender = emailSender;
        _emailConfig = emailConfig;
    }
    [HttpPost]
    public IActionResult SendEmail(
        string nameContact, 
        string emailContact, 
        string subjectContact, 
        string messageContact)
    {
        var message = new Message(new[] {_emailConfig.From}, $"Contact form: {subjectContact}",
            $"Name: {nameContact}\nEmail: {emailContact}\n\n{messageContact}");
        _emailSender.SendEmailAsync(message);

        return Ok("sent successfully");
    }
}