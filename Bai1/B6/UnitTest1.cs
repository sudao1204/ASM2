namespace B6
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class SinhVienPolyTests
        {
            private SinhVienPoly _sinhVienPoly;

            [SetUp]
            public void Setup()
            {
                _sinhVienPoly = new SinhVienPoly();
            }

            // Test cho chức năng "Thêm" sinh viên
            [Test]
            public void AddSinhVien_ValidSinhVien_IncreasesCount()
            {
                // Arrange
                var sv = new SinhVien("1", "Nguyen Van A", "L01", "Lop 1", "SV001");

                // Act
                _sinhVienPoly.AddSinhVien(sv);

                // Assert
                Assert.AreEqual(1, _sinhVienPoly.FindByMaSV("SV001") != null ? 1 : 0);
            }

            [Test]
            public void AddSinhVien_TenLopWithSpecialCharacters_ThrowsArgumentException()
            {
                // Arrange
                var sv = new SinhVien("2", "Nguyen Van B", "L02", "Lop@2", "SV002");

                // Act & Assert
                Assert.Throws<ArgumentException>(() => _sinhVienPoly.AddSinhVien(sv));
            }

            [Test]
            public void AddSinhVien_TenLopWithPunctuation_ThrowsArgumentException()
            {
                // Arrange
                var sv = new SinhVien("3", "Nguyen Van C", "L03", "Lop 3!", "SV003");

                // Act & Assert
                Assert.Throws<ArgumentException>(() => _sinhVienPoly.AddSinhVien(sv));
            }

            [Test]
            public void AddSinhVien_EmptyTenLop_ThrowsArgumentException()
            {
                // Arrange
                var sv = new SinhVien("4", "Nguyen Van D", "L04", "", "SV004");

                // Act & Assert
                Assert.Throws<ArgumentException>(() => _sinhVienPoly.AddSinhVien(sv));
            }

            [Test]
            public void AddSinhVien_ValidTenLop_IncreasesCount()
            {
                // Arrange
                var sv = new SinhVien("5", "Nguyen Van E", "L05", "Lop 5", "SV005");

                // Act
                _sinhVienPoly.AddSinhVien(sv);

                // Assert
                Assert.AreEqual(1, _sinhVienPoly.FindByMaSV("SV005") != null ? 1 : 0);
            }

            [Test]
            public void AddSinhVien_MultipleValidStudents_IncreasesCountCorrectly()
            {
                // Arrange
                var sv1 = new SinhVien("6", "Nguyen Van F", "L06", "Lop 6", "SV006");
                var sv2 = new SinhVien("7", "Nguyen Van G", "L07", "Lop 7", "SV007");
                _sinhVienPoly.AddSinhVien(sv1);
                _sinhVienPoly.AddSinhVien(sv2);

                // Act
                var count = _sinhVienPoly.FindByMaSV("SV006") != null ? 1 : 0;
                count += _sinhVienPoly.FindByMaSV("SV007") != null ? 1 : 0;

                // Assert
                Assert.AreEqual(2, count);
            }
            [Test]
            public void AddSinhVien_TenLopWithOnlySpaces_ThrowsArgumentException()
            {
                // Arrange
                var sv = new SinhVien("11", "Nguyen Van K", "L11", "   ", "SV011");

                // Act & Assert
                Assert.Throws<ArgumentException>(() => _sinhVienPoly.AddSinhVien(sv));
            }

            // Test cho chức năng "Tìm kiếm" theo mã sinh viên
            [Test]
            public void FindByMaSV_ExistingMaSV_ReturnsCorrectSinhVien()
            {
                // Arrange
                var sv = new SinhVien("8", "Nguyen Van H", "L08", "Lop 8", "SV008");
                _sinhVienPoly.AddSinhVien(sv);

                // Act
                var result = _sinhVienPoly.FindByMaSV("SV008");

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual("Nguyen Van H", result.HoTen);
            }

            [Test]
            public void FindByMaSV_NonExistingMaSV_ReturnsNull()
            {
                // Arrange
                var sv = new SinhVien("9", "Nguyen Van I", "L09", "Lop 9", "SV009");
                _sinhVienPoly.AddSinhVien(sv);

                // Act
                var result = _sinhVienPoly.FindByMaSV("SV010");

                // Assert
                Assert.IsNull(result);
            }

            [Test]
            public void FindByMaSV_CaseInsensitive_ReturnsCorrectSinhVien()
            {
                // Arrange
                var sv = new SinhVien("10", "Nguyen Van J", "L10", "Lop 10", "SV010");
                _sinhVienPoly.AddSinhVien(sv);

                // Act
                var result = _sinhVienPoly.FindByMaSV("sv010");

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual("Nguyen Van J", result.HoTen);
            }

            [Test]
            public void FindByMaSV_EmptyMaSV_ReturnsNull()
            {
                // Act
                var result = _sinhVienPoly.FindByMaSV("");

                // Assert
                Assert.IsNull(result);
            }

            [Test]
            public void FindByMaSV_NullMaSV_ReturnsNull()
            {
                // Act
                var result = _sinhVienPoly.FindByMaSV(null);

                // Assert
                Assert.IsNull(result);
            }
        }
    }
}