using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRMVCDmz.Data.Entities
{
    public class Calls
    {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Problem { get; set; }
    public DateTime CallTime { get; set; } = DateTime.Now ;
    public bool Answered { get; set; } = false;
    public DateTime AnswerTime { get; set; } = DateTime.Now ;
  }
}
