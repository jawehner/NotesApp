using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Models
{
    public class NoteListItem
    {
        [Display(Name="Note ID")]
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset DateCreatedUtc { get; set; }

        public override string ToString() => Title;
    }
}
