using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mondayWebApp.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        //[Required(ErrorMessage = "Proszę wprowadzić nazwę project.")]
        [StringLength(50)]
        public string ProjectName { get; set; }
        //[Required(ErrorMessage = "Proszę wprowadzić opis project.")]
        [StringLength(250)]
        public string ProjectDesc { get; set; }
        //[Required(ErrorMessage = "Proszę wprowadzić założenia project.")]
        [StringLength(250)]
        public string ProjectBrief { get; set; }
        //[Required(ErrorMessage = "Proszę wprowadzić datę endings project.")]
        public DateTime ProjectDeadline { get; set; }

        // Nawiguje do ProjectManager
        public int? ProjectManagerID { get; set; }
        //[Required(ErrorMessage = "Proszę wybrać kierownika project.")]
        public Employee ProjectManager { get; set; }

        // Nawiguje do zadań project
        public ICollection<ProjectTask> ProjectTasks { get; set; }

        // Nawiguje do listy pracwoników
        public ICollection<Employee> Employees { get; set; }

        // Blokuje rekord przed edycją
        public bool IsEdited { get; set; }

        // Wskazuje czy zaznazono rekord
        public bool IsChecked { get; set; }
    }
}
