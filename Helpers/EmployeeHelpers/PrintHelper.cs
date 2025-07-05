using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public static class PrintHelper
    {
        public static Image LogoImage { get; set; }

        public static void PrintAppointment(
            PrintPageEventArgs e,
            DateTime appointmentDate,
            string ownerName,
            string cnic,
            string phone,
            string address,
            string carNumber,
            string make,
            string carModel,
            string color,
            string year,
            List<string> services,
            List<string> paymentMethods,
            List<string> assignedEmployees,
            string bookedBy,
            string total,
            string discount,
            string grandTotal)
        {
            Graphics g = e.Graphics;
            var marginBounds = e.MarginBounds;
            int pageWidth = marginBounds.Width;
            int pageHeight = marginBounds.Height;
            int startX = marginBounds.Left;
            int startY = marginBounds.Top;
            int y = startY;

            // Logo
            if (LogoImage != null)
            {
                int logoWidth = 250;
                int logoHeight = 250;
                int logoX = startX + (pageWidth - logoWidth) / 2;
                g.DrawImage(LogoImage, new Rectangle(logoX, y, logoWidth, logoHeight));
                y += logoHeight + 10;
            }

            // Header
            using (Font headerFont = new Font("Arial", 24, FontStyle.Bold))
            {
                SizeF headerSize = g.MeasureString("Appointment Details", headerFont);
                g.DrawString("Appointment Details", headerFont, Brushes.DarkBlue, startX + (pageWidth - headerSize.Width) / 2, y);
                y += (int)headerSize.Height + 20;
            }

            using (Font detailsFont = new Font("Arial", 12))
            {
                int lineHeight = (int)g.MeasureString("A", detailsFont).Height + 5;

                void DrawLine(string label, string value)
                {
                    g.DrawString(label, detailsFont, Brushes.Black, startX + 20, y);
                    g.DrawString(value, detailsFont, Brushes.Black, startX + 180, y);
                    y += lineHeight;
                }

                // Main Details
                DrawLine("Appointment Date:", appointmentDate.ToShortDateString());
                DrawLine("Owner Name:", ownerName);
                DrawLine("CNIC:", cnic);
                DrawLine("Phone:", phone);
                DrawLine("Address:", address);
                DrawLine("Car Number:", carNumber);
                DrawLine("Make:", make);
                DrawLine("Car Model:", carModel);
                DrawLine("Color:", color);
                DrawLine("Year:", year);
                DrawLine("Services:", string.Join(", ", services));
                DrawLine("Payment Method(s):", string.Join(", ", paymentMethods));
                DrawLine("Booked By:", bookedBy);
                DrawLine("Assigned Employee:", string.Join(", ", assignedEmployees));

                // Totals
                y += 20;
                int footerStartY = startY + pageHeight - 150;
                int rightMargin = startX + pageWidth - 250;

                using (Font totalFont = new Font("Arial", 14, FontStyle.Bold))
                {
                    g.DrawString("Total:", totalFont, Brushes.Black, rightMargin, footerStartY);
                    g.DrawString(total, totalFont, Brushes.Black, rightMargin + 150, footerStartY);
                    footerStartY += lineHeight + 5;

                    g.DrawString("Discount:", totalFont, Brushes.Black, rightMargin, footerStartY);
                    g.DrawString(discount, totalFont, Brushes.Black, rightMargin + 150, footerStartY);
                    footerStartY += lineHeight + 5;

                    g.DrawString("Grand Total:", totalFont, Brushes.Black, rightMargin, footerStartY);
                    g.DrawString(grandTotal, totalFont, Brushes.Black, rightMargin + 150, footerStartY);
                }

                // Footer
                string footerText = $"Pristine Shine © {DateTime.Now.Year} All rights reserved";
                using (Font footerFont = new Font("Arial", 10, FontStyle.Italic))
                {
                    SizeF footerSize = g.MeasureString(footerText, footerFont);
                    float footerX = startX + (pageWidth - footerSize.Width) / 2;
                    float footerY = startY + pageHeight - 40;
                    g.DrawString(footerText, footerFont, Brushes.Gray, footerX, footerY);
                }
            }
        }
    }
}