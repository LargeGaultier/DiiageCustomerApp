using Caltec.StudentInfoProject.Business.Dto;

namespace Caltec.StudentInfoProject.Business.Tests
{
    public class StudentServiceTests : TestBase
    {
        private StudentService _studentService;
        [SetUp]
        public void Setup()
        {
            _studentService = _injector.GetService<StudentService>();
        }

        [Test]
        public async Task InsertStudent()
        {
            var result = await _studentService.InsertStudent(new StudentDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "John.doe@diiage.org"
                
            },CancellationToken.None);
            Assert.IsNotNull(result);

        }
        [Test]
        public async Task UpdateStudent()
        {
            var result = await _studentService.InsertStudent(new StudentDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "John.doe@diiage.org"

            }, CancellationToken.None);

            result.FirstName = "Jane";

            var resultUpdate = await _studentService.UpdateAsync(result, CancellationToken.None);
            Assert.IsNotNull(resultUpdate);
        }


    }
}
