using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class CreateQuestionCmd
    {
        [Required]
        public string Title { get; private set; }
        [Required]
        public string Description { get; private set; }
        public string Tag { get; private set; }

        public CreateQuestionCmd(string title, string description, string tag)
        {
            this.Title = title;
            this.Description = description;
            this.Tag = tag;
        }
    }
}
