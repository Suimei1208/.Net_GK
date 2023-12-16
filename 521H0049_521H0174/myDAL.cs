
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;
using _521H0049_521H0174.Models;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace _521H0049_521H0174
{
    internal class myDAL
    {
        private Model1 dbContext;

        public myDAL()
        {
            dbContext = new Model1();
        }

        // myDAL.UserExists will return true if exist valid parameters, else return false
        public async Task<bool> UserExists(string username, string password)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.Username == username);

            //bool isValid = VerifyPassword(password, user.Password);
            return user != null; //&& isValid;
        }

        

        public async void updateAvatar(string username, string avatar) {
            User user = dbContext.Users.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                user.Avatar = avatar;
                await dbContext.SaveChangesAsync();
            }
        }

        public string GetAvatarPath(string username)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.Username == username);
            return user?.Avatar;
        }

        public string GetRole(string username)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.Username == username);
            return user?.Role;
        }

        public int GetLatestUserId()
        {

            int latestUserId = dbContext.Users.Max(u => (int?)u.UserID) ?? 0;
            return latestUserId;
        }

        public void LogUserLogin(string username)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.Username == username);

            int latestLoginHistoryId = dbContext.LoginHistories.Max(l => (int?)l.LoginHistoryID) ?? 0;

            int newLoginHistoryId = latestLoginHistoryId + 1;

            SharedData.Instance.SetUser(user.UserID, user.Username,user.Role);

            LoginHistory loginLog = new LoginHistory
            {
                LoginHistoryID= newLoginHistoryId,
                UserID = user.UserID,
                LoginTime = DateTime.Now
            };

            dbContext.LoginHistories.Add(loginLog);
            dbContext.SaveChanges();

        }

        public string GetUserStatusByUsername(string username)
        {
            User user = dbContext.Users.FirstOrDefault(u => u.Username == username);
            return user?.Status;
        }


        public bool IsExisted(string username,  string phone)
        {
            return dbContext.Users.Any(u => u.Username == username || u.PhoneNumber == phone);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 10);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        public List<object> GetAllUsers()
        {
            return dbContext.Users.Select(u => new
            {
                UserID = u.UserID,
                Username = u.Username,
                FullName = u.FullName,
                Role = u.Role,
                Age = u.Age,
                PhoneNumber = u.PhoneNumber,
                Status = u.Status
            }).ToList().Cast<object>().ToList();
        }

        public List<string> GetAllUserRoles()
        {
            List<string> userRoles = dbContext.Users.Select(u => u.Role).Distinct().ToList();

            return userRoles;
        }

        public List<object> GetUsersByRole(string role)
        {
            return dbContext.Users.Select(u => new
            {
                UserID = u.UserID,
                Username = u.Username,
                FullName = u.FullName,
                Role = u.Role,
                Age = u.Age,
                PhoneNumber = u.PhoneNumber,
                Status = u.Status
            }).Where(u => u.Role == role).ToList().Cast<object>().ToList();
        }

        public List<KeyValuePair<int, string>> GetFilterData()
        {
            var data = dbContext.Users
                .Select(u => new { u.UserID, u.Username })
                .ToList();

            return data
                .Select(d => new KeyValuePair<int, string>(d.UserID, d.Username))
                .ToList();
        }

        public List<object> GetLoginHistoryByUserId(int userId)
        {
            return dbContext.LoginHistories
                .Where(l => l.UserID == userId)
                .OrderByDescending(l => l.LoginTime)
                .Join(
                    dbContext.Users,
                    login => login.UserID,
                    user => user.UserID,
                    (login, user) => new
                    {
                        Username = user.Username,
                        login.LoginTime
                    })
                .ToList()
                .Cast<object>()
                .ToList();
        }

        public List<object> GetLoginHistory()
        {
            return dbContext.LoginHistories
                .OrderByDescending(l => l.LoginTime)
                .Join(
                    dbContext.Users,
                    login => login.UserID,
                    user => user.UserID,
                    (login, user) => new
                    {
                        Username = user.Username,
                        login.LoginTime
                    })
                .ToList()
                .Cast<object>()
                .ToList();
        }


        public async void AddUser(User user)
        {
            
            dbContext.Users.Add(user);
            dbContext.Database.Log = Console.Write;
            await dbContext.SaveChangesAsync();
            
            
        }

        public async Task DeleteUser(int userId)
        {
            var loginHistoryToDelete = dbContext.LoginHistories.Where(l => l.UserID == userId);
            dbContext.LoginHistories.RemoveRange(loginHistoryToDelete);

            User userToDelete = dbContext.Users.FirstOrDefault(u => u.UserID == userId);
            if (userToDelete != null)
            {
                dbContext.Users.Remove(userToDelete);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateUser(User updatedUser)
        {
            User userToUpdate = dbContext.Users.FirstOrDefault(u => u.UserID == updatedUser.UserID); 
            if (userToUpdate != null)
            {
                if (updatedUser.Avatar != null) 
                {
                    userToUpdate.Avatar = updatedUser.Avatar;
                }
                if (updatedUser.Username != null)
                {
                    userToUpdate.Username = updatedUser.Username;
                }
                if (updatedUser.FullName != null)
                {
                    userToUpdate.FullName = updatedUser.FullName;
                }
                if (updatedUser.Age != null)
                {
                    userToUpdate.Age = updatedUser.Age;
                }
                if (updatedUser.PhoneNumber != null)
                { 
                    userToUpdate.PhoneNumber = updatedUser.PhoneNumber;
                }
                if (updatedUser.Status!=null)
                {
                    userToUpdate.Status = updatedUser.Status;
                }
                

                await dbContext.SaveChangesAsync();
            }
        }

        public List<Certificate> GetCertificates()
        {
            return dbContext.Certificates.ToList();
        }

        public List<object> GetAllStudent()
        {
            var students = dbContext.Students.Select(u => new
            {
                StudentID = u.StudentID,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Age = u.Age,
                Gender = u.Gender,
                PhoneNumber = u.PhoneNumber,
                Status = u.Status,
                GPA = u.GPA,
            }).ToList();

            var result = students.Select(s => new
            {
                s.StudentID,
                s.FirstName,
                s.LastName,
                s.Age,
                s.Gender,
                s.PhoneNumber,
                s.Status,
                s.GPA,
            }).ToList().Cast<object>().ToList();

            return result;
        }

        public async void AddStudent(Student student)
        {
            dbContext.Students.Add(student);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateStudent(Student updatedStudent)
        {
            Student existingStudent = dbContext.Students.FirstOrDefault(s => s.StudentID == updatedStudent.StudentID);

            if (existingStudent != null)
            {
                if (updatedStudent.FirstName != null) { existingStudent.FirstName = updatedStudent.FirstName; }
                
                if (updatedStudent.LastName != null) { existingStudent.LastName = updatedStudent.LastName; }
                
                if (updatedStudent.PhoneNumber != null) { existingStudent.PhoneNumber = updatedStudent.PhoneNumber; }
                
                if (updatedStudent.Age != null) { existingStudent.Age = updatedStudent.Age; }
                
                if (updatedStudent.Status != null) { existingStudent.Status = updatedStudent.Status; }
                
                if (updatedStudent.Gender != null) { existingStudent.Gender = updatedStudent.Gender; }
                
                if (updatedStudent.GPA != null) { existingStudent.GPA = updatedStudent.GPA; }


                await dbContext.SaveChangesAsync();
            }
            
        }

        public async Task DeleteStudent(int studentId)
        {
            
            Student studentToDelete = dbContext.Students.FirstOrDefault(s => s.StudentID == studentId);

            if (studentToDelete != null)
            {
                dbContext.Students.Remove(studentToDelete);

                await dbContext.SaveChangesAsync();
            }
           
        }

        public List<object> GetFilteredStudents(string status, string gender)
        {
            var query = dbContext.Students.AsQueryable();

            if (status != "All")
            {
                query = query.Where(s => s.Status == status);
            }

            if (gender != "All")
            {
                query = query.Where(s => s.Gender == gender);
            }

            var filteredStudents = query.Select(s => new
            {
                StudentID = s.StudentID,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Gender = s.Gender,
                PhoneNumber = s.PhoneNumber,
                Status = s.Status,
                GPA = s.GPA,
            }).ToList().Cast<object>().ToList();

            return filteredStudents;
        }

        public List<object> GetFilteredStudents(string status, string gender, double? maxGPA)
        {
            var query = dbContext.Students.AsQueryable();

            if (status != "All")
            {
                query = query.Where(s => s.Status == status);
            }

            if (gender != "All")
            {
                query = query.Where(s => s.Gender == gender);
            }

            if (maxGPA.HasValue)
            {
                query = query.Where(s => s.GPA <= maxGPA.Value);
            }

            var filteredStudents = query.Select(s => new
            {
                StudentID = s.StudentID,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Gender = s.Gender,
                PhoneNumber = s.PhoneNumber,
                Status = s.Status,
                GPA = s.GPA,
            }).ToList().Cast<object>().ToList();

            return filteredStudents;
        }


        public void dispose()
        {
            dbContext.Dispose();
        }
    }
}
