using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using attendance.Models;

namespace attendance.Pages.attendances
{
    public class DetailsModel : PageModel
    {
        private readonly AttendanceContext _context;

        public DetailsModel(AttendanceContext context)
        {
            _context = context;
        }

        public Attendance Attendance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendance = await _context.Attendance.FirstOrDefaultAsync(m => m.ID == id);

            if (Attendance == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
