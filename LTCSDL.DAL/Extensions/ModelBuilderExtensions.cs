using LTCSDL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LTCSDL.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Chapter
            modelBuilder.Entity<Chapter>().HasData(
                new Chapter { ChapterId = 1, Name = "Bệnh nhiễm trùng và ký sinh trùng" },
                new Chapter { ChapterId = 2, Name = "U (U tân sinh)" },
                new Chapter { ChapterId = 3, Name = "Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch" },
                new Chapter { ChapterId = 4, Name = "Bệnh nội tiết, dinh dưỡng và chuyển hóa" },
                new Chapter { ChapterId = 5, Name = "Rối loạn tâm thần và hành vi" },
                new Chapter { ChapterId = 6, Name = "Bệnh hệ thần kinh" },
                new Chapter { ChapterId = 7, Name = "Bệnh mắt và phần phụ" },
                new Chapter { ChapterId = 8, Name = "Bệnh của tai và xương chũm" },
                new Chapter { ChapterId = 9, Name = "Bệnh hệ tuần hoàn" },
                new Chapter { ChapterId = 10, Name = "Bệnh Hô hấp" },
                new Chapter { ChapterId = 11, Name = "Bệnh hệ tiêu hoá" },
                new Chapter { ChapterId = 12, Name = "Nhiễm trùng da và tổ chức dưới da" },
                new Chapter { ChapterId = 13, Name = "Bệnh của hệ cơ – xương khớp và mô liên kết" },
                new Chapter { ChapterId = 14, Name = "Bệnh hệ sinh dục – Tiết niệu" },
                new Chapter { ChapterId = 15, Name = "Thai nghén, sinh đẻ và hậu sản" },
                new Chapter { ChapterId = 16, Name = "Một số bệnh lý xuất phát trong thời kỳ chu sinh" },
                new Chapter { ChapterId = 17, Name = "Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể" },
                new Chapter { ChapterId = 18, Name = "Các triệu chứng, dấu hiệu và những biển hiện lâm sàng, cận lâm sàng bất thường, chưa được phân loại ở phần khác" },
                new Chapter { ChapterId = 19, Name = "Vết thương ngộ độc và hậu quả của 1 số nguyên nhân bên ngoài" },
                new Chapter { ChapterId = 20, Name = "Các nguyên nhân ngoại sinh của bệnh và tử vong" },
                new Chapter { ChapterId = 21, Name = "Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế" },
                new Chapter { ChapterId = 22, Name = "Mã phục vụ những mục đích đặc biệt" }
            );

            // Group
            modelBuilder.Entity<Group>().HasData(
                //Chapter Id 1 Bệnh nhiễm trùng và ký sinh trùng
                new Group { GroupId = 7, Name = "Viêm gan virus", ChapterId = 1 },
                new Group { GroupId = 8, Name = "Bệnh lao", ChapterId = 1 },
                new Group { GroupId = 9, Name = "Bệnh do Rickettsia", ChapterId = 1 },
                new Group { GroupId = 10, Name = "Bệnh do xoắn trùng khác", ChapterId = 1 },
                new Group { GroupId = 11, Name = "Di chứng của bệnh nhiễm trùng và ký sinh trùng", ChapterId = 1 },
                new Group { GroupId = 12, Name = "Nhiễm virus ở hệ thần kinh trung ương", ChapterId = 1 },
                new Group { GroupId = 13, Name = "Bệnh chấy rận, bệnh ghẻ và nhiễm ký sinh trùng khác", ChapterId = 1 },
                new Group { GroupId = 14, Name = "Bệnh giun sán", ChapterId = 1 },
                new Group { GroupId = 15, Name = "Bệnh nhiễm trùng lây truyền chủ yếu qua đường tình dục", ChapterId = 1 },
                new Group { GroupId = 16, Name = "Các tác nhân vi khuẩn, virus và tác nhân gây nhiễm khuẩn khác", ChapterId = 1 },
                new Group { GroupId = 17, Name = "Bệnh nhiễm trùng đường ruột", ChapterId = 1 },
                new Group { GroupId = 18, Name = "Nhiễm virus có đặc điểm tổn thương tại da và niêm mạc", ChapterId = 1 },
                new Group { GroupId = 19, Name = "Bệnh nhiễm khuẩn khác", ChapterId = 1 },
                new Group { GroupId = 20, Name = "Bệnh do ký sinh trùng đơn bào", ChapterId = 1 },
                new Group { GroupId = 21, Name = "Bệnh nhiễm nấm", ChapterId = 1 },

                //Chapter Id 2 U (U tân sinh)
                new Group { GroupId = 22, Name = "U lành", ChapterId = 2 },
                new Group { GroupId = 23, Name = "U tân sinh không chắc chắn hoặc không biết tính chất", ChapterId = 2 },
                new Group { GroupId = 24, Name = "U tân sinh tại chỗ", ChapterId = 2 },
                new Group { GroupId = 25, Name = "U ác được chẩn đoán xác định hay nghi ngờ là nguyên phát của các cơ quan xác định, ngoại trừ của mô bạch huyết, mô tạo huyết và mô liên", ChapterId = 2 },
                new Group { GroupId = 26, Name = "U ác tính", ChapterId = 2 },

                //Chapter Id 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
                new Group { GroupId = 27, Name = "Bệnh thiếu máu dinh dưỡng", ChapterId = 3 },
                new Group { GroupId = 28, Name = "Các rối loạn đông máu, ban xuất huyết và tình trạng xuất huyết khác", ChapterId = 3 },
                new Group { GroupId = 29, Name = "Các bệnh khác của máu và cơ quan tạo máu", ChapterId = 3 },
                new Group { GroupId = 30, Name = "Suy tuỷ xương và các bệnh thiếu máu khác", ChapterId = 3 },
                new Group { GroupId = 31, Name = "U ác tính", ChapterId = 3 },
                new Group { GroupId = 32, Name = "Thiếu máu tan máu", ChapterId = 3 },

                //Chapter Id 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                new Group { GroupId = 33, Name = "Suy dinh dưỡng", ChapterId = 4 },
                new Group { GroupId = 34, Name = "Các rối loạn khác về sự điều hoà glucose và bài tiết của tụy nội tiết", ChapterId = 4 },
                new Group { GroupId = 35, Name = "Bệnh tuyến giáp", ChapterId = 4 },
                new Group { GroupId = 36, Name = "Những bệnh thiếu dinh dưỡng khác", ChapterId = 4 },
                new Group { GroupId = 37, Name = "Rối loạn chuyển hoá", ChapterId = 4 },
                new Group { GroupId = 38, Name = "Rối loạn các tuyến nội tiết khác", ChapterId = 4 },
                new Group { GroupId = 39, Name = "Đái tháo đường", ChapterId = 4 },
                new Group { GroupId = 40, Name = "Béo phì và –tình trạng thừa dinh dưỡng khác", ChapterId = 4 },

                //Chapter Id 5 Rối loạn tâm thần và hành vi
                new Group { GroupId = 41, Name = "Rối loạn khí sắc [cảm xúc]", ChapterId = 5 },
                new Group { GroupId = 42, Name = "Các rối loạn bệnh tâm căn có liên quan đến stress và rối loạn dạng cơ thể", ChapterId = 5 },
                new Group { GroupId = 43, Name = "Tâm thần phân liệt, rối loạn loại phân liệt và các rối loạn hoang tưởng", ChapterId = 5 },
                new Group { GroupId = 44, Name = "Rối loạn tâm thần và hành vi do sử dụng chất tác động tâm thần", ChapterId = 5 },
                new Group { GroupId = 45, Name = "Chậm phát triển tâm thần", ChapterId = 5 },
                new Group { GroupId = 46, Name = "Các rối loạn về phát triển tâm lý", ChapterId = 5 },
                new Group { GroupId = 47, Name = "Hội chứng hành vi kết hợp với rối loạn sinh lý và nhân tố cơ thể", ChapterId = 5 },
                new Group { GroupId = 48, Name = "Các rối loạn hành vi và cảm xúc thường khởi phát ở tuổi trẻ em và thanh thiếu niên", ChapterId = 5 },
                new Group { GroupId = 49, Name = "Rối loạn tâm thần không biệt định", ChapterId = 5 },
                new Group { GroupId = 50, Name = "Rối loạn nhân cách và hành vi ở người trưởng thành", ChapterId = 5 },
                new Group { GroupId = 51, Name = "Rối loạn tâm thần thực tổn bao gồm rối loạn tâm thần triệu chứng", ChapterId = 5 },

                //Chapter Id 6 Bệnh hệ thần kinh
                new Group { GroupId = 52, Name = "Bệnh mất myelin của hệ thần kinh trung ướng", ChapterId = 6 },
                new Group { GroupId = 53, Name = "Bệnh chu kỳ và kịch phát", ChapterId = 6 },
                new Group { GroupId = 54, Name = "Bệnh dây, rễ và đám rối thần kinh", ChapterId = 6 },
                new Group { GroupId = 55, Name = "Bệnh thoái hoá khác của hệ thần kinh", ChapterId = 6 },
                new Group { GroupId = 56, Name = "Bệnh viêm hệ thần kinh trung ương", ChapterId = 6 },
                new Group { GroupId = 57, Name = "Các bệnh khác của hệ thần kinh", ChapterId = 6 },
                new Group { GroupId = 58, Name = "Viêm nhiều dây thần kinh và bệnh hệ thần kinh ngoại biên khác", ChapterId = 6 },
                new Group { GroupId = 59, Name = "Bệnh của khớp thần kinh - cơ và cơ", ChapterId = 6 },
                new Group { GroupId = 60, Name = "Bại não và những hội chứng liệt khác", ChapterId = 6 },
                new Group { GroupId = 61, Name = "Hội chứng ngoại tháp và rối loạn vận động", ChapterId = 6 },
                new Group { GroupId = 62, Name = "Bệnh teo hệ thống ảnh hưởng chủ yếu tới hệ thần kinh trung ương", ChapterId = 6 },

                //Chapter Id 7 Bệnh mắt và phần phụ
                new Group { GroupId = 63, Name = "Bệnh thủy tinh thể", ChapterId = 7 },
                new Group { GroupId = 64, Name = "Rối loạn thị giác và mù lòa", ChapterId = 7 },
                new Group { GroupId = 65, Name = "Bệnh dịch kính và nhãn cầu", ChapterId = 7 },
                new Group { GroupId = 66, Name = "Bệnh của kết mạc", ChapterId = 7 },
                new Group { GroupId = 67, Name = "Bệnh mắt và phần phụ", ChapterId = 7 },
                new Group { GroupId = 68, Name = "Bệnh glôcôm", ChapterId = 7 },
                new Group { GroupId = 69, Name = "Bệnh củng mạc, giác mạc, mống mắt và thể mi", ChapterId = 7 },
                new Group { GroupId = 70, Name = "Bệnh cơ vận nhãn, vận nhãn hai mắt điều tiết và khúc xạ", ChapterId = 7 },
                new Group { GroupId = 71, Name = "Bệnh hắc mạc và võng mạc", ChapterId = 7 },
                new Group { GroupId = 72, Name = "Bệnh của mí mắt, lệ bộ và hốc mắt", ChapterId = 7 },
                new Group { GroupId = 73, Name = "Bệnh thần kinh thị và đường dẫn thị giác", ChapterId = 7 },

                //Chapter Id 8 Bệnh của tai và xương chũm
                new Group { GroupId = 74, Name = "Bệnh của tai ngoài", ChapterId = 8 },
                new Group { GroupId = 75, Name = "Bệnh của tai giữa và xương chũm", ChapterId = 8 },
                new Group { GroupId = 76, Name = "Bệnh khác của tai", ChapterId = 8 },
                new Group { GroupId = 77, Name = "Bệnh của tai trong", ChapterId = 8 },

                //Chapter Id 9 Bệnh hệ tuần hoàn
                new Group { GroupId = 78, Name = "Thể bệnh tim khác", ChapterId = 9 },
                new Group { GroupId = 79, Name = "Bệnh tim thiếu máu cục bộ", ChapterId = 9 },
                new Group { GroupId = 80, Name = "Bệnh lý tăng huyết áp", ChapterId = 9 },
                new Group { GroupId = 81, Name = "Thấp khớp cấp", ChapterId = 9 },
                new Group { GroupId = 82, Name = "Bệnh tĩnh mạch, mạch bạch huyết và hạch bạch huyết không phân loại nơi khác", ChapterId = 9 },
                new Group { GroupId = 83, Name = "Bệnh tim do phổi và bệnh tuần hoàn phổi", ChapterId = 9 },
                new Group { GroupId = 84, Name = "Bệnh động mạch, tiểu động mạch và mao mạch", ChapterId = 9 },
                new Group { GroupId = 85, Name = "Rối loạn khác và không xác định của hệ tuần hoàn", ChapterId = 9 },
                new Group { GroupId = 86, Name = "Bệnh mạch máu não", ChapterId = 9 },
                new Group { GroupId = 87, Name = "Bệnh tim mạn tính do thấp", ChapterId = 9 },

                //Chapter Id 10 Bệnh Hô hấp
                new Group { GroupId = 88, Name = "Nhiễm trùng đường hô hấp dưới cấp khác", ChapterId = 10 },
                new Group { GroupId = 89, Name = "Bệnh hô hấp dưới mạn tính", ChapterId = 10 },
                new Group { GroupId = 90, Name = "Cúm và viêm phổi", ChapterId = 10 },
                new Group { GroupId = 91, Name = "Các bệnh hô hấp khác ảnh hưởng chủ yếu đến mô kẽ", ChapterId = 10 },
                new Group { GroupId = 92, Name = "Các bệnh khác của đường hô hấp trên", ChapterId = 10 },
                new Group { GroupId = 93, Name = "Các bệnh lý khác của hệ hô hấp", ChapterId = 10 },
                new Group { GroupId = 94, Name = "Bệnh khác của màng phổi", ChapterId = 10 },
                new Group { GroupId = 95, Name = "Tình trạng nung mủ và hoại tử của đường hô hấp dưới", ChapterId = 10 },
                new Group { GroupId = 96, Name = "Nhiễm trùng hô hấp trên cấp", ChapterId = 10 },
                new Group { GroupId = 97, Name = "Các bệnh phổi do tác nhân bên ngoài", ChapterId = 10 },

                //Chapter 11 Bệnh hệ tiêu hoá
                new Group { GroupId = 98, Name = "Bệnh đường ruột khác", ChapterId = 11 },
                new Group { GroupId = 99, Name = "Bệnh túi mật, ống mật và tụy", ChapterId = 11 },
                new Group { GroupId = 100, Name = "Bệnh của gan", ChapterId = 11 },
                new Group { GroupId = 101, Name = "Bệnh của phúc mạc", ChapterId = 11 },
                new Group { GroupId = 102, Name = "Bệnh của thực quản, dạ dày và tá tràng", ChapterId = 11 },
                new Group { GroupId = 103, Name = "Thoát vị", ChapterId = 11 },
                new Group { GroupId = 104, Name = "Bệnh của khoang miệng, tuyến nước bọt và xương hàm", ChapterId = 11 },
                new Group { GroupId = 105, Name = "Bệnh khác của hệ tiêu hoá", ChapterId = 11 },
                new Group { GroupId = 106, Name = "Bệnh ruột thừa", ChapterId = 11 },
                new Group { GroupId = 107, Name = "Viêm ruột non và đại tràng không do nhiễm trùng", ChapterId = 11 },

                //Chapter 12 Nhiễm trùng da và tổ chức dưới da
                new Group { GroupId = 108, Name = "Nhiễm khuẩn da và mô dưới da", ChapterId = 12 },
                new Group { GroupId = 109, Name = "Các bệnh khác của da và tổ chức dưới da    ", ChapterId = 12 },
                new Group { GroupId = 110, Name = "Các bệnh da và tổ chức dưới da liên quan đến bức xạ", ChapterId = 12 },
                new Group { GroupId = 111, Name = "Bệnh da bọng nước", ChapterId = 12 },
                new Group { GroupId = 112, Name = "Viêm da và chàm", ChapterId = 12 },
                new Group { GroupId = 113, Name = "Mày đay và hồng ban", ChapterId = 12 },
                new Group { GroupId = 114, Name = "Các bệnh phần phụ của da", ChapterId = 12 },
                new Group { GroupId = 115, Name = "Bệnh sẩn có vảy", ChapterId = 12 },

                //Chapter 13 Bệnh của hệ cơ – xương khớp và mô liên kết
                new Group { GroupId = 116, Name = "Bệnh của xương và sụn", ChapterId = 13 },
                new Group { GroupId = 117, Name = "Bệnh khớp", ChapterId = 13 },
                new Group { GroupId = 118, Name = "Bệnh cột sống", ChapterId = 13 },
                new Group { GroupId = 119, Name = "Các bệnh khác của hệ cơ - xương - khớp và mô liên kết", ChapterId = 13 },
                new Group { GroupId = 120, Name = "Bệnh mô liên kết hệ thống", ChapterId = 13 },
                new Group { GroupId = 121, Name = "Các bệnh lý mô mềm", ChapterId = 13 },

                //Chapter 14 Bệnh hệ sinh dục – Tiết niệu
                new Group { GroupId = 122, Name = "Bệnh cầu thận", ChapterId = 14 },
                new Group { GroupId = 123, Name = "Sỏi tiết niệu", ChapterId = 14 },
                new Group { GroupId = 124, Name = "Các rối loạn khác của hệ sinh dục tiết niệu", ChapterId = 14 },
                new Group { GroupId = 125, Name = "Biến đổi không do viêm của đường sinh dục nữ", ChapterId = 14 },
                new Group { GroupId = 126, Name = "Bệnh cơ quan sinh dục nam", ChapterId = 14 },
                new Group { GroupId = 127, Name = "Các bệnh khác của hệ tiết niệu", ChapterId = 14 },
                new Group { GroupId = 128, Name = "Bệnh kẽ ống thận", ChapterId = 14 },
                new Group { GroupId = 129, Name = "Suy thận", ChapterId = 14 },
                new Group { GroupId = 130, Name = "Các rối loạn khác của thận và niệu quản", ChapterId = 14 },
                new Group { GroupId = 131, Name = "Các biến đổi của vú", ChapterId = 14 },
                new Group { GroupId = 132, Name = "Viêm cơ quan sinh dục vùng chậu nữ", ChapterId = 14 },

                //Chapter 15 Thai nghén, sinh đẻ và hậu sản
                new Group { GroupId = 133, Name = "Biến chứng của chuyển dạ và đẻ", ChapterId = 15 },
                new Group { GroupId = 134, Name = "Cuộc đẻ", ChapterId = 15 },
                new Group { GroupId = 135, Name = "Phù, protein niệu và tăng huyết áp trong khi có thai, khi đẻ và sau đẻ", ChapterId = 15 },
                new Group { GroupId = 136, Name = "Chăm sóc bà mẹ liên quan đến thai, buồng ối và có thể là các vấn đề khi đẻ", ChapterId = 15 },
                new Group { GroupId = 137, Name = "Các bệnh lý khác của bà mẹ chủ yếu liên quan đến thai nghén", ChapterId = 15 },
                new Group { GroupId = 138, Name = "Thai nghén và sẩy thai", ChapterId = 15 },
                new Group { GroupId = 139, Name = "Biến chứng chủ yếu liên quan đến sau đẻ", ChapterId = 15 },
                new Group { GroupId = 140, Name = "Các tình trạng sản khoa khác, chưa được phân loại ở phần khác (O94-O99)", ChapterId = 15 },

                //Chapter 16 Một số bệnh lý xuất phát trong thời kỳ chu sinh
                new Group { GroupId = 141, Name = "Thai nhi và trẻ sơ sinh bị ảnh hưởng do các yếu tố về phía mẹ và bởi các biến chứng của thời kỳ thai nghén, chuyển dạ và cuộc đẻ", ChapterId = 16 },
                new Group { GroupId = 142, Name = "Các rối loạn nội tiết, chuyển hóa tạm thời đặc hiệu cho thai và trẻ sơ sinh", ChapterId = 16 },
                new Group { GroupId = 143, Name = "Rối loạn chảy máu và huyết học của thai và trẻ sơ sinh", ChapterId = 16 },
                new Group { GroupId = 144, Name = "Chấn thương khi sinh", ChapterId = 16 },
                new Group { GroupId = 145, Name = "Rối loạn hô hấp và tim mạch đặc hiệu cho giai đoạn chu sinh", ChapterId = 16 },
                new Group { GroupId = 146, Name = "Nhiễm khuẩn đặc hiệu trong thời kỳ chu sinh", ChapterId = 16 },
                new Group { GroupId = 147, Name = "Các bệnh lý của da và điều hòa thân nhiệt của thai và trẻ sơ sinh", ChapterId = 16 },
                new Group { GroupId = 148, Name = "Các rối loạn của hệ thống tiêu hóa ở thai và trẻ sơ sinh", ChapterId = 16 },
                new Group { GroupId = 149, Name = "Các rối loạn liên quan đến tuổi thai và sự phát triển của thai", ChapterId = 16 },
                new Group { GroupId = 150, Name = "Các bệnh lý khác xuất phát từ giai đoạn chu sinh", ChapterId = 16 },

                //Chapter 17 Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể
                new Group { GroupId = 151, Name = "Dị tật và biến dạng bẩm sinh của hệ cơ xương", ChapterId = 17 },
                new Group { GroupId = 152, Name = "Các dị tật bẩm sinh khác của hệ tiêu hoá", ChapterId = 17 },
                new Group { GroupId = 153, Name = "Dị tật bẩm sinh của cơ quan sinh dục", ChapterId = 17 },
                new Group { GroupId = 154, Name = "Các dị tật bẩm sinh của hệ tiết niệu", ChapterId = 17 },
                new Group { GroupId = 155, Name = "Các dị tật bẩm sinh của hệ thống tuần hoàn", ChapterId = 17 },
                new Group { GroupId = 156, Name = "Khe hở môi và khe hở vòm miệng", ChapterId = 17 },
                new Group { GroupId = 157, Name = "Các dị tật bẩm sinh khác", ChapterId = 17 },
                new Group { GroupId = 158, Name = "Dị tật bẩm sinh hệ thần kinh trung ương", ChapterId = 17 },
                new Group { GroupId = 159, Name = "Các bất thường nhiễm sắc thể, chưa được phân loại", ChapterId = 17 },
                new Group { GroupId = 160, Name = "Các dị tật bẩm sinh ở mắt, tai, mặt và cổ", ChapterId = 17 },
                new Group { GroupId = 161, Name = "Các bất thường bẩm sinh của bộ máy hô hấp", ChapterId = 17 },

                //Chapter 18 Các triệu chứng, dấu hiệu và những biển hiện lâm sàng, cận lâm sàng bất thường, chưa được phân loại ở phần khác
                new Group { GroupId = 162, Name = "Triệu chứng và dấu hiệu liên quan tới hệ tiêu hoá và bụng", ChapterId = 18 },
                new Group { GroupId = 163, Name = "Triệu chứng và dấu hiệu tổng quát", ChapterId = 18 },
                new Group { GroupId = 164, Name = "Triệu chứng và dấu hiệu liên quan tới hệ tuần hoàn và hô hấp", ChapterId = 18 },
                new Group { GroupId = 165, Name = "Triệu chứng và dấu hiệu liên quan tới ngôn ngữ và giọng nói", ChapterId = 18 },
                new Group { GroupId = 166, Name = "Triệu chứng và dấu hiệu liên quan tới nhận thức, tri giác và trạng thái cảm", ChapterId = 18 },
                new Group { GroupId = 167, Name = "Phát hiện bất thường về xét nghiệm máu, không có chẩn đoán", ChapterId = 18 },
                new Group { GroupId = 168, Name = "Triệu chứng và dấu hiệu liên quan tới hệ thần kinh và hệ cơ xương", ChapterId = 18 },
                new Group { GroupId = 169, Name = "Các phát hiện bất thường về xét nghiệm nước tiểu, không có chẩn đoán", ChapterId = 18 },
                new Group { GroupId = 170, Name = "Các phát hiện bất thường về chẩn đoán hình ảnh và thăm dò chức năng, không có chẩn đoán", ChapterId = 18 },
                new Group { GroupId = 171, Name = "Triệu chứng và dấu hiệu liên quan tới da và tổ chức dưới da", ChapterId = 18 },
                new Group { GroupId = 172, Name = "Nguyên nhân tử vong không xác định", ChapterId = 18 },
                new Group { GroupId = 173, Name = "Các phát hiện bất thường về xét nghiệm các dịch cơ thể các chất và mô, không có chẩn đoán", ChapterId = 18 },
                new Group { GroupId = 174, Name = "Triệu chứng và dấu hiệu liên quan tới hệ tiết niệu", ChapterId = 18 },

                //Chapter 19 Vết thương ngộ độc và hậu quả của 1 số nguyên nhân bên ngoài
                new Group { GroupId = 175, Name = "Một vài biến chứng sớm của chấn thương", ChapterId = 19 },
                new Group { GroupId = 176, Name = "Tổn thương ở cổ tay và bàn tay", ChapterId = 19 },
                new Group { GroupId = 177, Name = "Di chứng của tổn thương, của nhiễm độc và của hậu quả khác của căn nguyên từ bên ngoài", ChapterId = 19 },
                new Group { GroupId = 178, Name = "Tổn thương tại háng và đùi", ChapterId = 19 },
                new Group { GroupId = 179, Name = "Tổn thương tác động nhiều vùng cơ thể", ChapterId = 19 },
                new Group { GroupId = 180, Name = "Tác động của vật lạ vào qua lỗ tự nhiên", ChapterId = 19 },
                new Group { GroupId = 181, Name = "Tổn thương tại khuỷu tay và cẳng tay", ChapterId = 19 },
                new Group { GroupId = 182, Name = "Bỏng và ăn mòn", ChapterId = 19 },
                new Group { GroupId = 183, Name = "Ngộ độc do thuốc, dược phẩm và chất sinh học", ChapterId = 19 },
                new Group { GroupId = 184, Name = "Tổn thương tại cổ chân và bàn chân", ChapterId = 19 },
                new Group { GroupId = 185, Name = "Tổn thương phần chưa xác định của thân, các chi hoặc vùng cơ thể", ChapterId = 19 },
                new Group { GroupId = 186, Name = "Tổn thương bụng, lưng dưới, cột sống thắt lưng và chân hông", ChapterId = 19 },
                new Group { GroupId = 187, Name = "Biến chứng phẫu thuật và chăm sóc y tế không xếp loại ở nơi khác", ChapterId = 19 },
                new Group { GroupId = 188, Name = "Tổn thương lồng ngực", ChapterId = 19 },
                new Group { GroupId = 189, Name = "Tổn thương tại đầu gối và cẳng chân", ChapterId = 19 },
                new Group { GroupId = 190, Name = "Tổn thương do cóng lạnh", ChapterId = 19 },
                new Group { GroupId = 191, Name = "Tổn thương ở đầu", ChapterId = 19 },
                new Group { GroupId = 192, Name = "Tổn thương của cổ", ChapterId = 19 },
                new Group { GroupId = 193, Name = "Vết thương vai và cánh tay", ChapterId = 19 },
                new Group { GroupId = 194, Name = "Ngộ độc chất chủ yếu không có nguồn gốc y học", ChapterId = 19 },
                new Group { GroupId = 195, Name = "Tác dụng khác và chưa xác định của căn nguyên bên ngoài", ChapterId = 19 },

                //Chapter 20 Các nguyên nhân ngoại sinh của bệnh và tử vong
                new Group { GroupId = 196, Name = "Can thiệp pháp lý và hành động chiến tranh", ChapterId = 20 },
                new Group { GroupId = 197, Name = "Di chứng của các nguyên nhân bên ngoài gây biến chứng và tử vong", ChapterId = 20 },
                new Group { GroupId = 198, Name = "Tai nạn", ChapterId = 20 },
                new Group { GroupId = 199, Name = "Tấn công", ChapterId = 20 },
                new Group { GroupId = 200, Name = "Biến chứng do chăm sóc y tế và phẫu thuật", ChapterId = 20 },
                new Group { GroupId = 201, Name = "Biến cố do ý đồ không xác định được.", ChapterId = 20 },
                new Group { GroupId = 202, Name = "Các yếu tố bổ sung liên quan đến các nguyên nhân gây ra biến chứng và tử vong được sắp xếp ở nơi khác", ChapterId = 20 },
                new Group { GroupId = 203, Name = "Cố tình tự hại", ChapterId = 20 },

                //Chapter 21 Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế
                new Group { GroupId = 204, Name = "Những người có nguy cơ sức khoẻ tiềm ẩn liên quan đến bệnh sử gia đình và cá nhân và một số tình trạng ảnh hưởng đến sức khoẻ", ChapterId = 21 },
                new Group { GroupId = 205, Name = "Những người có nguy cơ sức khoẻ tiềm tàng liên quan đến những hoàn cảnh kinh tế xã hội và tâm lý xã hội", ChapterId = 21 },
                new Group { GroupId = 206, Name = "Người bệnh đến cơ sở y tế trong các hoàn cảnh khác", ChapterId = 21 },
                new Group { GroupId = 207, Name = "Những người có nguy cơ tiềm tàng về sức khoẻ liên quan đến các bệnh lây truyền", ChapterId = 21 },
                new Group { GroupId = 208, Name = "Những người đến cơ quan y tế về các vấn đề liên quan đến sinh sản", ChapterId = 21 },
                new Group { GroupId = 209, Name = "Những người đến cơ sở y tế để khám và kiểm tra sức khoẻ", ChapterId = 21 },
                new Group { GroupId = 210, Name = "Những người đến cơ sở y tế để được chăm sóc và tiến hành các thủ thuật đặc biệt", ChapterId = 21 },

                //Chapter 22 Mã phục vụ những mục đích đặc biệt
                new Group { GroupId = 211, Name = "Mã tạm thời cho một số bệnh mới hoặc chưa rõ bệnh nguyên hoặc sử dụng trong cấp cứu", ChapterId = 22 },
                new Group { GroupId = 212, Name = "Kháng các thuốc kháng sinh và chống ung thư", ChapterId = 22 }
            );

            //Number
            modelBuilder.Entity<Number>().HasData(
               /// Chapter Id 1 Bệnh nhiễm trùng và ký sinh trùng
               // Group 7 - 21
               new Number { NumberId = 1, Name = "Số TT 1", GroupId = 7 },
               new Number { NumberId = 2, Name = "Số TT 1", GroupId = 8 },
               new Number { NumberId = 3, Name = "Số TT 1", GroupId = 9 },
               new Number { NumberId = 4, Name = "Số TT 1", GroupId = 10 },
               new Number { NumberId = 5, Name = "Số TT 1", GroupId = 11 },
               new Number { NumberId = 6, Name = "Số TT 1", GroupId = 12 },
               new Number { NumberId = 7, Name = "Số TT 1", GroupId = 13 },
               new Number { NumberId = 8, Name = "Số TT 1", GroupId = 14 },
               new Number { NumberId = 9, Name = "Số TT 1", GroupId = 15 },
               new Number { NumberId = 10, Name = "Số TT 1", GroupId = 16 },
               new Number { NumberId = 11, Name = "Số TT 1", GroupId = 17 },
               new Number { NumberId = 12, Name = "Số TT 1", GroupId = 18 },
               new Number { NumberId = 13, Name = "Số TT 1", GroupId = 19 },
               new Number { NumberId = 14, Name = "Số TT 1", GroupId = 20 },
               new Number { NumberId = 15, Name = "Số TT 1", GroupId = 21 },

               /// Chapter Id 2 U (U tân sinh)
               //  Group 22 - 26
               new Number { NumberId = 16, Name = "Số TT 2", GroupId = 22 },
               new Number { NumberId = 17, Name = "Số TT 2", GroupId = 23 },
               new Number { NumberId = 18, Name = "Số TT 2", GroupId = 24 },
               new Number { NumberId = 19, Name = "Số TT 2", GroupId = 25 },
               new Number { NumberId = 20, Name = "Số TT 2", GroupId = 26 },

               /// Chapter Id 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
               //  Group 27 - 32
               new Number { NumberId = 21, Name = "Số TT 3", GroupId = 27 },
               new Number { NumberId = 22, Name = "Số TT 3", GroupId = 28 },
               new Number { NumberId = 23, Name = "Số TT 3", GroupId = 29 },
               new Number { NumberId = 24, Name = "Số TT 3", GroupId = 30 },
               new Number { NumberId = 25, Name = "Số TT 3", GroupId = 31 },
               new Number { NumberId = 26, Name = "Số TT 3", GroupId = 32 },

               /// Chapter Id 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
               //  Group 33 - 40
               new Number { NumberId = 27, Name = "Số TT 1", GroupId = 33 },
               new Number { NumberId = 28, Name = "Số TT 4", GroupId = 33 },
               new Number { NumberId = 29, Name = "Số TT 4", GroupId = 34 },
               new Number { NumberId = 30, Name = "Số TT 4", GroupId = 35 },
               new Number { NumberId = 31, Name = "Số TT 4", GroupId = 36 },
               new Number { NumberId = 32, Name = "Số TT 4", GroupId = 37 },
               new Number { NumberId = 33, Name = "Số TT 4", GroupId = 38 },
               new Number { NumberId = 34, Name = "Số TT 4", GroupId = 39 },
               new Number { NumberId = 35, Name = "Số TT 4", GroupId = 40 },

               /// Chapter Id 5 Rối loạn tâm thần và hành vi
               //  Group 41 - 51
               new Number { NumberId = 36, Name = "Số TT 1", GroupId = 41 },
               new Number { NumberId = 37, Name = "Số TT 5", GroupId = 41 },
               new Number { NumberId = 38, Name = "Số TT 5", GroupId = 42 },
               new Number { NumberId = 39, Name = "Số TT 5", GroupId = 43 },
               new Number { NumberId = 40, Name = "Số TT 5", GroupId = 44 },
               new Number { NumberId = 41, Name = "Số TT 5", GroupId = 45 },
               new Number { NumberId = 42, Name = "Số TT 5", GroupId = 46 },
               new Number { NumberId = 43, Name = "Số TT 5", GroupId = 47 },
               new Number { NumberId = 44, Name = "Số TT 5", GroupId = 48 },
               new Number { NumberId = 45, Name = "Số TT 5", GroupId = 49 },
               new Number { NumberId = 46, Name = "Số TT 5", GroupId = 50 },
               new Number { NumberId = 47, Name = "Số TT 5", GroupId = 51 },

               /// Chapter Id 6 Bệnh hệ thần kinh
               //  Group 52 - 62
               new Number { NumberId = 48, Name = "Số TT 6", GroupId = 52 },
               new Number { NumberId = 49, Name = "Số TT 6", GroupId = 53 },
               new Number { NumberId = 50, Name = "Số TT 6", GroupId = 54 },
               new Number { NumberId = 51, Name = "Số TT 6", GroupId = 55 },
               new Number { NumberId = 52, Name = "Số TT 6", GroupId = 56 },
               new Number { NumberId = 53, Name = "Số TT 6", GroupId = 57 },
               new Number { NumberId = 54, Name = "Số TT 6", GroupId = 58 },
               new Number { NumberId = 55, Name = "Số TT 6", GroupId = 59 },
               new Number { NumberId = 56, Name = "Số TT 6", GroupId = 60 },
               new Number { NumberId = 57, Name = "Số TT 6", GroupId = 61 },
               new Number { NumberId = 58, Name = "Số TT 6", GroupId = 62 },

               /// Chapter Id 7 Bệnh mắt và phần phụ
               // Group 63 - 77
               new Number { NumberId = 59, Name = "Số TT 7", GroupId = 63 },
               new Number { NumberId = 60, Name = "Số TT 7", GroupId = 64 },
               new Number { NumberId = 61, Name = "Số TT 7", GroupId = 65 },
               new Number { NumberId = 62, Name = "Số TT 7", GroupId = 66 },
               new Number { NumberId = 63, Name = "Số TT 7", GroupId = 67 },
               new Number { NumberId = 64, Name = "Số TT 7", GroupId = 68 },
               new Number { NumberId = 65, Name = "Số TT 7", GroupId = 69 },
               new Number { NumberId = 66, Name = "Số TT 7", GroupId = 70 },
               new Number { NumberId = 67, Name = "Số TT 7", GroupId = 71 },
               new Number { NumberId = 68, Name = "Số TT 7", GroupId = 72 },
               new Number { NumberId = 69, Name = "Số TT 7", GroupId = 73 },

               /// Chapter Id 8 Bệnh của tai và xương chũm
               // Group 74 - 77
               new Number { NumberId = 70, Name = "Số TT 8", GroupId = 74 },
               new Number { NumberId = 71, Name = "Số TT 8", GroupId = 75 },
               new Number { NumberId = 72, Name = "Số TT 8", GroupId = 76 },
               new Number { NumberId = 73, Name = "Số TT 8", GroupId = 77 },

               /// Chapter 9 Bệnh hệ tuần hoàn
               // Group 78 - 87
               new Number { NumberId = 74, Name = "Số TT 9", GroupId = 78 },
               new Number { NumberId = 75, Name = "Số TT 9", GroupId = 79 },
               new Number { NumberId = 76, Name = "Số TT 9", GroupId = 80 },
               new Number { NumberId = 77, Name = "Số TT 9", GroupId = 81 },
               new Number { NumberId = 78, Name = "Số TT 9", GroupId = 82 },
               new Number { NumberId = 79, Name = "Số TT 9", GroupId = 83 },
               new Number { NumberId = 80, Name = "Số TT 9", GroupId = 84 },
               new Number { NumberId = 81, Name = "Số TT 9", GroupId = 85 },
               new Number { NumberId = 82, Name = "Số TT 9", GroupId = 86 },
               new Number { NumberId = 83, Name = "Số TT 9", GroupId = 87 },

               /// Chapter 10 Bệnh Hô hấp
               //  Group 88 - 97
               new Number { NumberId = 84, Name = "Số TT 10", GroupId = 88 },
               new Number { NumberId = 85, Name = "Số TT 10", GroupId = 89 },
               new Number { NumberId = 86, Name = "Số TT 10", GroupId = 90 },
               new Number { NumberId = 87, Name = "Số TT 10", GroupId = 91 },
               new Number { NumberId = 88, Name = "Số TT 10", GroupId = 92 },
               new Number { NumberId = 89, Name = "Số TT 10", GroupId = 93 },
               new Number { NumberId = 90, Name = "Số TT 10", GroupId = 94 },
               new Number { NumberId = 91, Name = "Số TT 10", GroupId = 95 },
               new Number { NumberId = 92, Name = "Số TT 10", GroupId = 96 },
               new Number { NumberId = 93, Name = "Số TT 10", GroupId = 97 },

               /// Chapter 11 Bệnh hệ tiêu hoá
               //  Group 98 - 107
               new Number { NumberId = 94, Name = "Số TT 11", GroupId = 98 },
               new Number { NumberId = 95, Name = "Số TT 11", GroupId = 99 },
               new Number { NumberId = 96, Name = "Số TT 11", GroupId = 100 },
               new Number { NumberId = 97, Name = "Số TT 11", GroupId = 101 },
               new Number { NumberId = 98, Name = "Số TT 11", GroupId = 102 },
               new Number { NumberId = 99, Name = "Số TT 11", GroupId = 103 },
               new Number { NumberId = 100, Name = "Số TT 11", GroupId = 104 },
               new Number { NumberId = 101, Name = "Số TT 11", GroupId = 105 },
               new Number { NumberId = 102, Name = "Số TT 11", GroupId = 106 },
               new Number { NumberId = 103, Name = "Số TT 11", GroupId = 107 },

               /// Chapter 12 Nhiễm trùng da và tổ chức dưới da
               //  Group 108 - 115
               new Number { NumberId = 104, Name = "Số TT 12 ", GroupId = 108 },
               new Number { NumberId = 105, Name = "Số TT 12 ", GroupId = 109 },
               new Number { NumberId = 106, Name = "Số TT 12 ", GroupId = 110 },
               new Number { NumberId = 107, Name = "Số TT 12 ", GroupId = 111 },
               new Number { NumberId = 108, Name = "Số TT 12 ", GroupId = 112 },
               new Number { NumberId = 109, Name = "Số TT 12 ", GroupId = 113 },
               new Number { NumberId = 110, Name = "Số TT 12 ", GroupId = 114 },
               new Number { NumberId = 111, Name = "Số TT 12 ", GroupId = 115 },

               /// Chapter 13 Bệnh của hệ cơ – xương khớp và mô liên kết
               //  Group 116 - 121
               new Number { NumberId = 112, Name = "Số TT 13", GroupId = 116 },
               new Number { NumberId = 113, Name = "Số TT 13", GroupId = 117 },
               new Number { NumberId = 114, Name = "Số TT 13", GroupId = 118 },
               new Number { NumberId = 115, Name = "Số TT 13", GroupId = 119 },
               new Number { NumberId = 116, Name = "Số TT 13", GroupId = 120 },
               new Number { NumberId = 117, Name = "Số TT 13", GroupId = 121 },

               /// Chapter 14  Bệnh hệ sinh dục – Tiết niệu
               // Group 122 - 132
               new Number { NumberId = 118, Name = "Số TT 14", GroupId = 122 },
               new Number { NumberId = 119, Name = "Số TT 14", GroupId = 123 },
               new Number { NumberId = 120, Name = "Số TT 14", GroupId = 124 },
               new Number { NumberId = 121, Name = "Số TT 14", GroupId = 125 },
               new Number { NumberId = 122, Name = "Số TT 14", GroupId = 126 },
               new Number { NumberId = 123, Name = "Số TT 14", GroupId = 127 },
               new Number { NumberId = 124, Name = "Số TT 14", GroupId = 128 },
               new Number { NumberId = 125, Name = "Số TT 14", GroupId = 129 },
               new Number { NumberId = 126, Name = "Số TT 14", GroupId = 130 },
               new Number { NumberId = 127, Name = "Số TT 14", GroupId = 131 },
               new Number { NumberId = 128, Name = "Số TT 14", GroupId = 132 },

               /// Chapter 15 Thai nghén, sinh đẻ và hậu sản
               //  Group 133 - 140
               new Number { NumberId = 129, Name = "Số TT 15", GroupId = 134 },
               new Number { NumberId = 130, Name = "Số TT 15", GroupId = 135 },
               new Number { NumberId = 131, Name = "Số TT 15", GroupId = 135 },
               new Number { NumberId = 132, Name = "Số TT 15", GroupId = 137 },
               new Number { NumberId = 133, Name = "Số TT 15", GroupId = 138 },
               new Number { NumberId = 134, Name = "Số TT 15", GroupId = 139 },
               new Number { NumberId = 135, Name = "Số TT 15", GroupId = 140 },
               new Number { NumberId = 136, Name = "Số TT 15", GroupId = 141 },

               /// Chapter 16 Một số bệnh lý xuất phát trong thời kỳ chu sinh
               //  Group 141 - 150
               new Number { NumberId = 137, Name = "Số TT 16", GroupId = 142 },
               new Number { NumberId = 138, Name = "Số TT 16", GroupId = 143 },
               new Number { NumberId = 139, Name = "Số TT 16", GroupId = 144 },
               new Number { NumberId = 140, Name = "Số TT 16", GroupId = 144 },
               new Number { NumberId = 141, Name = "Số TT 16", GroupId = 146 },
               new Number { NumberId = 142, Name = "Số TT 16", GroupId = 147 },
               new Number { NumberId = 143, Name = "Số TT 16", GroupId = 148 },
               new Number { NumberId = 144, Name = "Số TT 16", GroupId = 149 },
               new Number { NumberId = 145, Name = "Số TT 16", GroupId = 150 },

               /// Chapter 17 Dị tật bẩm sinh, biến dạng và bất thường về nhiễm sắc thể
               //  Group 151 - 161
               new Number { NumberId = 146, Name = "Số TT 17", GroupId = 151 },
               new Number { NumberId = 147, Name = "Số TT 17", GroupId = 152 },
               new Number { NumberId = 148, Name = "Số TT 17", GroupId = 153 },
               new Number { NumberId = 149, Name = "Số TT 17", GroupId = 154 },
               new Number { NumberId = 150, Name = "Số TT 17", GroupId = 155 },
               new Number { NumberId = 151, Name = "Số TT 17", GroupId = 156 },
               new Number { NumberId = 152, Name = "Số TT 17", GroupId = 157 },
               new Number { NumberId = 153, Name = "Số TT 17", GroupId = 158 },
               new Number { NumberId = 154, Name = "Số TT 17", GroupId = 159 },
               new Number { NumberId = 155, Name = "Số TT 17", GroupId = 160 },
               new Number { NumberId = 156, Name = "Số TT 17", GroupId = 161 },

               /// Chapter 18 Các triệu chứng, dấu hiệu và những biển hiện lâm sàng, cận lâm sàng bất thường, chưa được phân loại ở phần khác
               // Group 162 - 174
               new Number { NumberId = 157, Name = "Số TT 18", GroupId = 162 },
               new Number { NumberId = 158, Name = "Số TT 18", GroupId = 163 },
               new Number { NumberId = 159, Name = "Số TT 18", GroupId = 164 },
               new Number { NumberId = 160, Name = "Số TT 18", GroupId = 165 },
               new Number { NumberId = 161, Name = "Số TT 18", GroupId = 166 },
               new Number { NumberId = 162, Name = "Số TT 18", GroupId = 167 },
               new Number { NumberId = 163, Name = "Số TT 18", GroupId = 168 },
               new Number { NumberId = 164, Name = "Số TT 18", GroupId = 169 },
               new Number { NumberId = 165, Name = "Số TT 18", GroupId = 170 },
               new Number { NumberId = 166, Name = "Số TT 18", GroupId = 171 },
               new Number { NumberId = 167, Name = "Số TT 18", GroupId = 172 },
               new Number { NumberId = 168, Name = "Số TT 18", GroupId = 173 },
               new Number { NumberId = 169, Name = "Số TT 18", GroupId = 174 },

               /// Chapter 19 Vết thương ngộ độc và hậu quả của 1 số nguyên nhân bên ngoài
               // Group 175 - 195
               new Number { NumberId = 170, Name = "Số TT 19", GroupId = 175 },
               new Number { NumberId = 171, Name = "Số TT 19", GroupId = 176 },
               new Number { NumberId = 172, Name = "Số TT 19", GroupId = 178 },
               new Number { NumberId = 173, Name = "Số TT 19", GroupId = 179 },
               new Number { NumberId = 174, Name = "Số TT 19", GroupId = 180 },
               new Number { NumberId = 175, Name = "Số TT 19", GroupId = 181 },
               new Number { NumberId = 176, Name = "Số TT 19", GroupId = 182 },
               new Number { NumberId = 177, Name = "Số TT 19", GroupId = 183 },
               new Number { NumberId = 178, Name = "Số TT 19", GroupId = 184 },
               new Number { NumberId = 179, Name = "Số TT 19", GroupId = 185 },
               new Number { NumberId = 180, Name = "Số TT 19", GroupId = 186 },
               new Number { NumberId = 181, Name = "Số TT 19", GroupId = 187 },
               new Number { NumberId = 182, Name = "Số TT 19", GroupId = 188 },
               new Number { NumberId = 183, Name = "Số TT 19", GroupId = 189 },
               new Number { NumberId = 184, Name = "Số TT 19", GroupId = 190 },
               new Number { NumberId = 185, Name = "Số TT 19", GroupId = 191 },
               new Number { NumberId = 186, Name = "Số TT 19", GroupId = 191 },
               new Number { NumberId = 187, Name = "Số TT 19", GroupId = 193 },
               new Number { NumberId = 188, Name = "Số TT 19", GroupId = 194 },
               new Number { NumberId = 189, Name = "Số TT 19", GroupId = 195 },

               /// Chapter 20 Các nguyên nhân ngoại sinh của bệnh và tử vong
               // Group 196 - 203
               new Number { NumberId = 190, Name = "Số TT 20", GroupId = 196 },
               new Number { NumberId = 191, Name = "Số TT 20", GroupId = 197 },
               new Number { NumberId = 192, Name = "Số TT 20", GroupId = 198 },
               new Number { NumberId = 193, Name = "Số TT 20", GroupId = 199 },
               new Number { NumberId = 194, Name = "Số TT 20", GroupId = 200 },
               new Number { NumberId = 195, Name = "Số TT 20", GroupId = 201 },
               new Number { NumberId = 196, Name = "Số TT 20", GroupId = 202 },
               new Number { NumberId = 197, Name = "Số TT 20", GroupId = 203 },

               /// Chapter 21 Các yếu tố ảnh hưởng đến tình trạng sức khỏe và tiếp xúc dịch vụ y tế
               //  Group 204 - 210
               new Number { NumberId = 198, Name = "Số TT 21", GroupId = 204 },
               new Number { NumberId = 199, Name = "Số TT 21", GroupId = 205 },
               new Number { NumberId = 200, Name = "Số TT 21", GroupId = 206 },
               new Number { NumberId = 201, Name = "Số TT 21", GroupId = 207 },
               new Number { NumberId = 202, Name = "Số TT 21", GroupId = 208 },
               new Number { NumberId = 203, Name = "Số TT 21", GroupId = 209 },
               new Number { NumberId = 204, Name = "Số TT 21", GroupId = 210 },

               /// Chapter 22 Mã phục vụ những mục đích đặc biệt
               //  Group 211 - 212
               new Number { NumberId = 205, Name = "Số TT 22", GroupId =  211},
               new Number { NumberId = 206, Name = "Số TT 22", GroupId =  212}
           );

            int _dID = 0;
            modelBuilder.Entity<Disease>().HasData(
                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 7 Viêm gan virus
                // Number 1
                new Disease { DiseaseId = ++_dID, EnglishName = "Acute hepatitis A", VietnameseName = "Viêm gan A cấp", Symptom = "Đang chờ cập nhập!", NumberId = 1},
                new Disease { DiseaseId = ++_dID, EnglishName = "Hepatitis A with hepatic coma", VietnameseName = "Viêm gan A có hôn mê gan", Symptom = "Đang chờ cập nhập!", NumberId = 1 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Acute hepatitis B", VietnameseName = "Viêm gan B cấp", Symptom = "Đang chờ cập nhập!", NumberId = 1 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Acute delta-(super)infection of hepatitis B carrier", VietnameseName = "Viêm gan D cấp tính bội nhiễm trên người mang viêm gan B", Symptom = "Đang chờ cập nhập!", NumberId = 1 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Chronic viral hepatitis", VietnameseName = "Viêm gan virus mạn", Symptom = "Đang chờ cập nhập!", NumberId = 1 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 8 Bệnh lao
                // Number 2
                new Disease { DiseaseId = ++_dID, EnglishName = "Respiratory tuberculosis, bacteriologically and histologically confirmed", VietnameseName = "Lao hô hấp, có xác nhận về vi khuẩn học và mô học", Symptom = "Đang chờ cập nhập!", NumberId = 2 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Tuberculosis of intrathoracic lymph nodes, confirmed bacteriologically and histologically", VietnameseName = "Lao hạch lympho trong lồng ngực, xác nhận về vi trùng học hoặc mô học", Symptom = "Đang chờ cập nhập!", NumberId = 2 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Tuberculous pleurisy, confirmed bacteriologically and histologically", VietnameseName = "Lao màng phổi, xác nhận về vi trùng học và mô học", Symptom = "Đang chờ cập nhập!", NumberId = 2 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Respiratory tuberculosis unspecified, confirmed bacteriologically and histologically", VietnameseName = "Lao hô hấp không xác định, xác nhận về vi trùng học và mô học", Symptom = "Đang chờ cập nhập!", NumberId = 2 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Primary respiratory tuberculosis without mention of bacteriological or histological confirmation", VietnameseName = "Lao hô hấp sơ nhiễm không đề cập đến việc xác nhận về vi khuẩn học và mô học", Symptom = "Đang chờ cập nhập!", NumberId = 2 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 9 
                // Number 3
                new Disease { DiseaseId = ++_dID, EnglishName = "Typhus fever", VietnameseName = "Bệnh sốt phát ban do Rickettsia", Symptom = "Đang chờ cập nhập!", NumberId = 3 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Typhus fever due to Rickettsia typhi", VietnameseName = "Sốt phát ban do Rickettsia typhi", Symptom = "Đang chờ cập nhập!", NumberId = 3 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other spotted fevers", VietnameseName = "Sốt phát ban dạng đốm khác", Symptom = "Đang chờ cập nhập!", NumberId = 3 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Q fever", VietnameseName = "Sốt Q", Symptom = "Đang chờ cập nhập!", NumberId = 3 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Trench fever", VietnameseName = "Sốt chiến hào", Symptom = "Đang chờ cập nhập!", NumberId = 3 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 10 
                // Number 4
                new Disease { DiseaseId = ++_dID, EnglishName = "Nonvenereal syphilis", VietnameseName = "Giang mai không lây qua đường tình dục", Symptom = "Đang chờ cập nhập!", NumberId = 4 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Yaws", VietnameseName = "Ghẻ cóc (do nhiễm Treponema pertenue)", Symptom = "Đang chờ cập nhập!", NumberId = 4 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other manifestations of yaws", VietnameseName = "Biểu hiện khác của ghẻ cóc", Symptom = "Đang chờ cập nhập!", NumberId = 4 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Primary lesions of pinta", VietnameseName = "Tổn thương tiên phát của pinta", Symptom = "Đang chờ cập nhập!", NumberId = 4 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other spirochaetal infections", VietnameseName = "Bệnh do xoắn trùng khác", Symptom = "Đang chờ cập nhập!", NumberId = 4 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 11 
                // Number 5
                new Disease { DiseaseId = ++_dID, EnglishName = "Sequelae of tuberculosis", VietnameseName = "Di chứng do lao", Symptom = "Đang chờ cập nhập!", NumberId = 5 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Sequelae of genitourinary tuberculosis", VietnameseName = "Di chứng do lao tiết niệu - sinh dục", Symptom = "Đang chờ cập nhập!", NumberId = 5 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Sequelae of tuberculosis of other organs", VietnameseName = "Di chứng do lao cơ quan khác", Symptom = "Đang chờ cập nhập!", NumberId = 5 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Sequelae of viral hepatitis", VietnameseName = "Di chứng viêm gan virus", Symptom = "Đang chờ cập nhập!", NumberId = 5 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Sequelae of trachoma", VietnameseName = "Di chứng bệnh mắt hột", Symptom = "Đang chờ cập nhập!", NumberId = 5 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 12 
                // Number 6
                new Disease { DiseaseId = ++_dID, EnglishName = "Acute poliomyelitis", VietnameseName = "Bệnh bại liệt cấp", Symptom = "Đang chờ cập nhập!", NumberId = 6 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Acute paralytic poliomyelitis, wild virus, indigenous", VietnameseName = "Bệnh bại liệt cấp, thể liệt, virus hoang dại, nội địa", Symptom = "Đang chờ cập nhập!", NumberId = 6 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Atypical virus infections of central nervous system", VietnameseName = "Bệnh do virus không điển hình ở hệ thần kinh trung ương", Symptom = "Đang chờ cập nhập!", NumberId = 6 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Rabies", VietnameseName = "Bệnh dại", Symptom = "Đang chờ cập nhập!", NumberId = 6 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other mosquito-borne viral encephalitis", VietnameseName = "Viêm não virus khác do muỗi truyền", Symptom = "Đang chờ cập nhập!", NumberId = 6 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 13 
                // Number 7
                new Disease { DiseaseId = ++_dID, EnglishName = "Pediculosis and phthiriasis", VietnameseName = "Bệnh chấy rận", Symptom = "Đang chờ cập nhập!", NumberId = 7 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Pediculosis due to Pediculus humanus capitis", VietnameseName = "Bệnh chấy rận do Pediculus humanus capitis", Symptom = "Đang chờ cập nhập!", NumberId = 7 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Scabies", VietnameseName = "Bệnh ngứa do ghẻ", Symptom = "Đang chờ cập nhập!", NumberId = 7 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Nasopharyngeal myiasis", VietnameseName = "Bệnh giòi ở mũi họng", Symptom = "Đang chờ cập nhập!", NumberId = 7 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other acariasis", VietnameseName = "Các bệnh do ve khác", Symptom = "Đang chờ cập nhập!", NumberId = 7 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 14
                // Number 8
                new Disease { DiseaseId = ++_dID, EnglishName = "Schistosomiasis [bilharziasis]", VietnameseName = "Bệnh sán máng [bilharziasis]", Symptom = "Đang chờ cập nhập!", NumberId = 8 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Cercarial dermatitis", VietnameseName = "Viêm da do ấu trùng", Symptom = "Đang chờ cập nhập!", NumberId = 8 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Fascioliasis", VietnameseName = "Bệnh Fasciola", Symptom = "Đang chờ cập nhập!", NumberId = 8 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other specified fluke infections", VietnameseName = "Nhiễm sán lá xác định khác", Symptom = "Đang chờ cập nhập!", NumberId = 8 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Fasciolopsiasis", VietnameseName = "Bệnh do Fasciolopsis", Symptom = "Đang chờ cập nhập!", NumberId = 8 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Taeniasis", VietnameseName = "Bệnh sán dây  ", Symptom = "Đang chờ cập nhập!", NumberId = 8 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 15
                // Number 9
                new Disease { DiseaseId = ++_dID, EnglishName = "Congenital syphilis", VietnameseName = "Giang mai bẩm sinh", Symptom = "Đang chờ cập nhập!", NumberId = 9 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Early congenital syphilis, unspecified", VietnameseName = "Giang mai bẩm sinh sớm, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 9 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Early syphilis", VietnameseName = "Giang mai sớm", Symptom = "Đang chờ cập nhập!", NumberId = 9 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other secondary syphilis", VietnameseName = "Giang mai thứ phát khác", Symptom = "Đang chờ cập nhập!", NumberId = 9 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other symptomatic late syphilis", VietnameseName = "Giang mai muộn khác có triệu chứng", Symptom = "Đang chờ cập nhập!", NumberId = 9 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 16 
                // Number 10
                new Disease { DiseaseId = ++_dID, EnglishName = "Streptococcus and staphylococcus as the cause of diseases classified to other chapters", VietnameseName = "Liên cầu và tụ cầu là nguyên nhân gây bệnh, được phân loại ở các chương khác", Symptom = "Đang chờ cập nhập!", NumberId = 10 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Streptococcus, group A, as the cause of diseases classified to other chapters", VietnameseName = "Liên cầu, nhóm A, là nguyên nhân gây các bệnh phân loại ở chương khác", Symptom = "Đang chờ cập nhập!", NumberId = 10 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Liên cầu, nhóm B, là nguyên nhân gây các bệnh phân loại ở chương khác", VietnameseName = "Streptococcus, group B, as the cause of diseases classified to other chapters", Symptom = "Đang chờ cập nhập!", NumberId = 10 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Streptococcus, group D, as the cause of diseases classified to other chapters", VietnameseName = "Liên cầu, nhóm D, là nguyên nhân gây các bệnh phân loại ở chương khác", Symptom = "Đang chờ cập nhập!", NumberId = 10 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Proteus (mirabilis)(morganii) as the cause of diseases classified to other chapters", VietnameseName = "Proteus (mirabilis)(morganii) gây các bệnh đã được phân loại ở chương khác", Symptom = "Đang chờ cập nhập!", NumberId = 10 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 17
                // Number 11
                new Disease { DiseaseId = ++_dID, EnglishName = "Cholera", VietnameseName = "Bệnh tả", Symptom = "Đang chờ cập nhập!", NumberId = 11 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Enterohaemorrhagic Escherichia coli infection", VietnameseName = "Nhiễm Escherichia coli gây xuất huyết đường ruột", Symptom = "Đang chờ cập nhập!", NumberId = 11 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Campylobacter enteritis", VietnameseName = "Viêm ruột do Campylobacter", Symptom = "Đang chờ cập nhập!", NumberId = 11 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Foodborne Clostridium perfringens [Clostridium welchii] intoxication", VietnameseName = "Nhiễm độc thức ăn do độc tố của Clostridium perfringens [Clostridium welchii]", Symptom = "Đang chờ cập nhập!", NumberId = 11 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other specified bacterial foodborne intoxications", VietnameseName = "Nhiễm độc thức ăn do độc tố của vi khuẩn xác định khác", Symptom = "Đang chờ cập nhập!", NumberId = 11 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 18
                // Number 12
                new Disease { DiseaseId = ++_dID, EnglishName = "Herpesviral [herpes simplex] infections", VietnameseName = "Bệnh do Herpes simplex", Symptom = "Đang chờ cập nhập!", NumberId = 12 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Herpesviral infection, unspecified", VietnameseName = "Nhiễm Virus Herpes, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 12 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Zoster [herpes zoster]", VietnameseName = "Bệnh do herpes zoster", Symptom = "Đang chờ cập nhập!", NumberId = 12 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Measles complicated by meningitisG02.0", VietnameseName = "Sởi biến chứng viêm màng não G02.0", Symptom = "Đang chờ cập nhập!", NumberId = 12 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Measles with intestinal complications", VietnameseName = "Sởi với biến chứng ở ruột", Symptom = "Đang chờ cập nhập!", NumberId = 12 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 19
                // Number 13
                new Disease { DiseaseId = ++_dID, EnglishName = "Leprosy [Hansen s disease]", VietnameseName = "Bệnh phong (bệnh Hansen)", Symptom = "Đang chờ cập nhập!", NumberId = 13 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Borderline tuberculoid leprosy", VietnameseName = "Bệnh phong thể củ ranh giới", Symptom = "Đang chờ cập nhập!", NumberId = 13 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Mycobacterial infection, unspecified", VietnameseName = "Nhiễm khuẩn mycobacteria không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 13 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Listerial meningitis and meningoencephalitis", VietnameseName = "Viêm màng não và viêm não màng não do listeria", Symptom = "Đang chờ cập nhập!", NumberId = 13 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Nasopharyngeal diphtheria", VietnameseName = "Bệnh bạch hầu thể mũi - họng", Symptom = "Đang chờ cập nhập!", NumberId = 13 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 20
                // Number 14
                new Disease { DiseaseId = ++_dID, EnglishName = "Other severe and complicated Plasmodium falciparum malaria", VietnameseName = "Sốt rét Plasmodium falciparum thể nặng và biến chứng khác", Symptom = "Đang chờ cập nhập!", NumberId = 14 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Plasmodium vivax malaria with other complications", VietnameseName = "Sốt rét Plasmodium vivax với biến chứng khác", Symptom = "Đang chờ cập nhập!", NumberId = 14 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Other parasitologically confirmed malaria, not elsewhere classified", VietnameseName = "Sốt rét khác xác nhận bằng ký sinh trùng học, chưa được phân loại", Symptom = "Đang chờ cập nhập!", NumberId = 14 },
                new Disease { DiseaseId = ++_dID, EnglishName = "African trypanosomiasis, unspecified", VietnameseName = "Bệnh do trypanosoma châu Phi, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 14 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Chagas disease (chronic) with other organ involvement", VietnameseName = "Bệnh Chagas (mạn tính) ảnh hưởng đến cơ quan khác", Symptom = "Đang chờ cập nhập!", NumberId = 14 },

                /// Chapter 1 Bệnh nhiễm trùng và ký sinh trùng
                // Group 21
                // Number 15
                new Disease { DiseaseId = ++_dID, EnglishName = "Tinea barbae and tinea capitis", VietnameseName = "Bệnh nấm ở cằm và nấm da đầu", Symptom = "Đang chờ cập nhập!", NumberId = 15 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Dermatophytosis, unspecified", VietnameseName = "Bệnh nấm da, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 15 },
                new Disease { DiseaseId = ++_dID, EnglishName = "White piedra", VietnameseName = "Bệnh nấm do Trichosporum cuteneum (râu, lông)", Symptom = "Đang chờ cập nhập!", NumberId = 15 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Candidiasis, unspecified", VietnameseName = "Nhiễm candida không xác định", Symptom = "Đang chờ cập nhập!", NumberId = 15 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Chronic pulmonary coccidioidomycosis", VietnameseName = "Nhiễm nấm coccidioides ở phổi mạn tính", Symptom = "Đang chờ cập nhập!", NumberId = 15 }
            );
        }
    }
}
