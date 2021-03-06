using System.IO;
using NUnit.Framework;
using Asm.Net.Mips;

namespace Asm.Net.Tests.Mips
{
    [TestFixture]
    public class MipsTest
    {
        [Test(Description = "should assemble single addi instruction")]
        public void should_assemble_single_addi_instruction()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Addi(Register.T1, Register.T2, 0);

                Assert.AreEqual(stream.ToArray(), new byte[] { 0, 0, 73, 33 });
            }
        }

    }
}
