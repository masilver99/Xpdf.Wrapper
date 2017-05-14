﻿namespace XpdfNet.Tests
{
    using System;
    using Xunit;

    public class ProcessServiceTest
    {
        private ProcessService ProcessService;

        [Fact]
        public void ToText_ShouldThrowExceptionWithPathInformation_WhenPDFToTextExeCanNotBeFound()
        {
            // Arrange
            string filename = "nonExistingfile.exe";
            string arguments = "arg1 arg2";
            string workingDirectory = "./";

            this.ProcessService = new ProcessService(filename, arguments, workingDirectory);

            // Act
            Exception ex = Assert.Throws<Exception>(() => this.ProcessService.StartAndWaitForExit());

            // Assert
            string expected = $"The system cannot find the file specified. Filename: {filename}, WorkingDirectory: {workingDirectory}.";
            Assert.Equal(expected, ex.Message);
        }
    }
}