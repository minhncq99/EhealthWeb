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
                new Disease { DiseaseId = ++_dID, EnglishName = "Chronic pulmonary coccidioidomycosis", VietnameseName = "Nhiễm nấm coccidioides ở phổi mạn tính", Symptom = "Đang chờ cập nhập!", NumberId = 15 },

                /// chapter 2 U(U tân sinh)
                // Group 22 U lành
                // Number 16
                new Disease { DiseaseId = ++_dID, EnglishName = "Benign neoplasm of mouth and pharynx", VietnameseName = "U lành của miệng và hầu", Symptom = "Đang chờ cập nhập!", NumberId = 16 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Benign neoplasm: Lip", VietnameseName = "U lành của môi", Symptom = "Đang chờ cập nhập!", NumberId = 16 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Benign neoplasm: Tongue", VietnameseName = "U lành của lưỡi", Symptom = "Đang chờ cập nhập!", NumberId = 16 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Benign neoplasm: Floor of mouth", VietnameseName = "U lành của sàn miệng", Symptom = "Đang chờ cập nhập!", NumberId = 16 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Benign neoplasm: Other and unspecified parts of mouth", VietnameseName = "U lành của phần khác và không xác định của miệng", Symptom = "Đang chờ cập nhập!", NumberId = 16 },

                /// chapter 2 U(U tân sinh)
                // Group 23 U tân sinh không chắc chắn hoặc không biết tính chất
                // Number 17
                new Disease { DiseaseId = ++_dID, EnglishName = "Neoplasm of uncertain or unknown behaviour of oral cavity and digestive organs", VietnameseName = "U tân sinh không rõ hoặc không biết tính chất của khoang miệng và cơ quan tiêu hoá", Symptom = "Đang chờ cập nhập!", NumberId = 17 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Neoplasm of uncertain or unknown behaviour: Lip, oral cavity and pharynx", VietnameseName = "U tân sinh chưa rõ tính chất của môi, xoang miệng và hầu", Symptom = "Đang chờ cập nhập!", NumberId = 17 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Neoplasm of uncertain or unknown behaviour: Stomach", VietnameseName = "U tân sinh chưa rõ tính chất của dạ dầy", Symptom = "Đang chờ cập nhập!", NumberId = 17 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Neoplasm of uncertain or unknown behaviour: Small intestine", VietnameseName = "U tân sinh chưa rõ tính chất của ruột non", Symptom = "Đang chờ cập nhập!", NumberId = 17 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Neoplasm of uncertain or unknown behaviour: Appendix", VietnameseName = "U tân sinh chưa rõ tính chất của ruột thừa", Symptom = "Đang chờ cập nhập!", NumberId = 17 },

                /// chapter 2 U(U tân sinh)
                // Group 24 U tân sinh tại chỗ
                // Number 18
                new Disease { DiseaseId = ++_dID, EnglishName = "Carcinoma in situ of oral cavity, oesophagus and stomach", VietnameseName = "Ung thư biểu mô tại chỗ của khoang miệng, thực quản và dạ dày", Symptom = "Đang chờ cập nhập!", NumberId = 18 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Carcinoma in situ: Lip, oral cavity and pharynx", VietnameseName = "Ung thư biểu mô tại chỗ của của môi khoang miệng và hầu", Symptom = "Đang chờ cập nhập!", NumberId = 18 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Carcinoma in situ: Oesophagus", VietnameseName = "Ung thư biểu mô tại chỗ của của thực quản", Symptom = "Đang chờ cập nhập!", NumberId = 18 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Carcinoma in situ: Stomach", VietnameseName = "U ác của Dạ dày", Symptom = "Đang chờ cập nhập!", NumberId = 18 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Carcinoma in situ of other and unspecified digestive organs", VietnameseName = "Ung thư biểu mô tại chỗ của cơ quan tiêu hoá khác và không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 18 },

                /// chapter 2 U(U tân sinh)
                // Group 25 U ác được chuẩn đoán xác định hay nghi ngờ là nguyên phát của các cơ quan xác định, ngoại trừ của mô bạch huyết, mô tạo huyết và mô liên
                // Number 19
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm: External upper lip", VietnameseName = "U ác của môi phần ngoài môi trên", Symptom = "Đang chờ cập nhập!", NumberId = 19 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm: External lower lip", VietnameseName = "Phần ngoài môi dưới", Symptom = "Đang chờ cập nhập!", NumberId = 19 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm: External lip, unspecified", VietnameseName = "U ác của phần ngoài môi không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 19 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm: Upper lip, inner aspect", VietnameseName = "U ác của môi trên, mặt trong", Symptom = "Đang chờ cập nhập!", NumberId = 19 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm: Lower lip, inner aspect", VietnameseName = "U ác của môi dưới, mặt trong", Symptom = "Đang chờ cập nhập!", NumberId = 19 },

                /// chapter 2 U(U tân sinh)
                // Group 26 U ác tính
                // Number 20
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm of lip", VietnameseName = "U ác của môi", Symptom = "Đang chờ cập nhập!", NumberId = 20 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm of base of tongue", VietnameseName = "U ác của đáy lưỡi", Symptom = "Đang chờ cập nhập!", NumberId = 20 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm of parotid gland", VietnameseName = "U ác tuyến mang tai", Symptom = "Đang chờ cập nhập!", NumberId = 20 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm of trachea", VietnameseName = "U ác khí quản", Symptom = "Đang chờ cập nhập!", NumberId = 20 },
                new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neoplasm of vagina", VietnameseName = "U ác của âm đạo", Symptom = "Đang chờ cập nhập!", NumberId = 20 },

                 /// chapter 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
                 // Group 27 bệnh thiếu máu dinh dưỡng
                 // Number 21
                 new Disease { DiseaseId = ++_dID, EnglishName = "Iron deficiency anaemia", VietnameseName = "Thiếu máu do thiếu sắt", Symptom = "Đang chờ cập nhập!", NumberId = 21 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Iron deficiency anaemia secondary to blood loss (chronic)", VietnameseName = "Thiếu máu thiếu sắt thứ phát do mất máu (mạn tính)", Symptom = "Đang chờ cập nhập!", NumberId = 21 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Sideropenic dysphagia", VietnameseName = "Chứng khó nuốt do thiếu sắt", Symptom = "Đang chờ cập nhập!", NumberId = 21 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other iron deficiency anaemias", VietnameseName = "Các thiếu máu thiếu sắt khác", Symptom = "Đang chờ cập nhập!", NumberId = 21 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Iron deficiency anaemia, unspecified", VietnameseName = "Thiếu máu thiếu sắt không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 21 },

                 /// chapter 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
                 // Group 28 Các rối loạn đông máu, ban xuất huyết và tình trạng xuất huyết khác
                 // Number 22
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disseminated intravascular coagulation (defibrination syndrome)", VietnameseName = "Đông máu nội mạch rải rác (hội chứng tiêu fibrin)", Symptom = "Đang chờ cập nhập!", NumberId = 22 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hereditary factor VIII dificiency", VietnameseName = "Thiếu yếu tố VIII di truyền", Symptom = "Đang chờ cập nhập!", NumberId = 22 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hereditary factor IX dificiency", VietnameseName = "Thiếu yếu tố IX di truyền", Symptom = "Đang chờ cập nhập!", NumberId = 22 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other coagulation defects", VietnameseName = "Các bất thường đông máu khác", Symptom = "Đang chờ cập nhập!", NumberId = 22 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Von Willebrand s disease", VietnameseName = "Bệnh Von Willebrand", Symptom = "Đang chờ cập nhập!", NumberId = 22 },

                 /// chapter 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
                 // Group 29 Các bệnh khác của máu và cơ quan tạo máu
                 // Number 23
                 new Disease { DiseaseId = ++_dID, EnglishName = "Agranulocytosis", VietnameseName = "Tình trạng không có bạch cầu hạt", Symptom = "Đang chờ cập nhập!", NumberId = 23 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Funtional disorders of polymorphonuclear neutrophils", VietnameseName = "Rối loạn chức năng bạch cầu hạt trung tính", Symptom = "Đang chờ cập nhập!", NumberId = 23 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of white blood cells", VietnameseName = "Các rối loạn khác của bạch cầu", Symptom = "Đang chờ cập nhập!", NumberId = 23 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Genetic anomalies of leukocytes", VietnameseName = "Bất thường di truyền của bạch cầu", Symptom = "Đang chờ cập nhập!", NumberId = 23 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Eosinophilia", VietnameseName = "Tình trạng tăng bạch cầu ưa acid", Symptom = "Đang chờ cập nhập!", NumberId = 23 },

                 /// chapter 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
                 // Group 30
                 // Number 24
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acquired pure red cell aplasia [erythroblastopenia]", VietnameseName = "Suy sủy xương một dòng hồng cầu mắc phải (giảm nguyên hồng cầu)", Symptom = "Đang chờ cập nhập!", NumberId = 24 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Chronic acquired pure red cell aplasia", VietnameseName = "Suy tủy xương một dòng hồng cầu mắc phải mạn tính", Symptom = "Đang chờ cập nhập!", NumberId = 24 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Transient acquired pure red cell aplasia", VietnameseName = "Suy tủy xương một dòng hồng cầu mắc phải thoáng qua", Symptom = "Đang chờ cập nhập!", NumberId = 24 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other acquired pure red cell aplasias", VietnameseName = "Suy tủy xương một dòng hồng cầu mắc phải khác", Symptom = "Đang chờ cập nhập!", NumberId = 24 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acquired pure red cell aplasia, unspecified", VietnameseName = "Suy tủy xương một dòng hồng cầu mắc phải không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 24 },

                 /// chapter 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch
                 // Group 31
                 // Number 25
                 new Disease { DiseaseId = ++_dID, EnglishName = "Immunodeficiency with predominantly antibody defects", VietnameseName = "Thiếu hụt miễn dịch chủ yếudo bất thường kháng thể", Symptom = "Đang chờ cập nhập!", NumberId = 25 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hereditary hypogammaglobulinaemia", VietnameseName = "Giảm gammaglobulin máu di truyền", Symptom = "Đang chờ cập nhập!", NumberId = 25 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Nonfamilial hypogammaglobulinaemia", VietnameseName = "Giảm gammaglobulin máu không có yếu tố gia đình", Symptom = "Đang chờ cập nhập!", NumberId = 25 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Selective deficiency of immunoglobulin A [IgA]", VietnameseName = "Thiếu hụt immunoglobulin A IgA chọn lọc", Symptom = "Đang chờ cập nhập!", NumberId = 25 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Selective deficiency of immunoglobulin G [IgG] subclasses", VietnameseName = "Thiếu hụt immunoglobulin A IgA chọn lọc", Symptom = "Đang chờ cập nhập!", NumberId = 25 },

                 /// chapter 3 Bệnh của máu, cơ quan tạo máu và các rối loạn liên quan đến cơ chế miễn dịch 
                 // Group 32
                 // Number 26
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anaemia due to enzyme disorders", VietnameseName = "Thiếu máu do rối loạn men", Symptom = "Đang chờ cập nhập!", NumberId = 26 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anaemia due to glucose-6-phosphate dehydrogenase [G6PD] deficiency", VietnameseName = "Thiếu máu do thiếu men glucose-6-phosphate dehydrogenase", Symptom = "Đang chờ cập nhập!", NumberId = 26 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anaemia due to other disorders of glutathione metabolism", VietnameseName = "Thiếu máu do các rối loạn chuyển hoá glutathione khác", Symptom = "Đang chờ cập nhập!", NumberId = 26 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anaemia due to disorders of glycolytic enzymes", VietnameseName = "Thiếu máu do rối loạn các men phân giải glucose", Symptom = "Đang chờ cập nhập!", NumberId = 26 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anaemia due to disorders of nucleotide metabolism", VietnameseName = "Thiếu máu do rối loạn chuyển hoá nucleotide", Symptom = "Đang chờ cập nhập!", NumberId = 26 },

                 /// chapter 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 33 Suy dinh dưỡng
                 // Number 27
                 new Disease { DiseaseId = ++_dID, EnglishName = "Kwashiorkor", VietnameseName = "Kwashiorkor", Symptom = "Đang chờ cập nhập!", NumberId = 27 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Nutritional marasmus", VietnameseName = "Suy dinh dưỡng thể marasmus", Symptom = "Đang chờ cập nhập!", NumberId = 27 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Marasmic kwashiorkor", VietnameseName = "Thể hỗn hợp Kwashiorkor-marasmus", Symptom = "Đang chờ cập nhập!", NumberId = 27 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Unspecified severe protein-energy malnutrition", VietnameseName = "Suy dinh dưỡng nặng do thiếu protein - năng lượng, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 27 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Protein-energy malnutrition of moderate and mild degree", VietnameseName = "Suy dinh dưỡng vừa và nhẹ do thiếu protein - năng lượng", Symptom = "Đang chờ cập nhập!", NumberId = 27 },

                 /// chapter  4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 34 các rối loạn về sự điều hòa glucose và bài tiết của tụy nội tiết
                 // Number 28
                 new Disease { DiseaseId = ++_dID, EnglishName = "Nondiabetic hypoglycaemic coma", VietnameseName = "Hôn mê hạ đường máu không do đái tháo đường", Symptom = "Đang chờ cập nhập!", NumberId = 28 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of pancreatic internal secretion", VietnameseName = "Rối loạn khác của tuyến tuỵ nội tiết", Symptom = "Đang chờ cập nhập!", NumberId = 28 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Drug-induced hypoglycaemia without coma", VietnameseName = "Hạ -glucose máu do thuốc, không hôn mê", Symptom = "Đang chờ cập nhập!", NumberId = 28 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other hypoglycaemia", VietnameseName = "Hạ -glucose máu khác", Symptom = "Đang chờ cập nhập!", NumberId = 28 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypoglycaemia, unspecified", VietnameseName = "Hạ -glucose máu không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 28 },

                 /// chapter 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 35 Bệnh tuyến giáp
                 // Number 29
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital iodine-deficiency syndrome", VietnameseName = "Hội chứng thiếu iod bẩm sinh", Symptom = "Đang chờ cập nhập!", NumberId = 29 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital iodine-deficiency syndrome, neurological type", VietnameseName = "Hội chứng thiếu iod bẩm sinh, thể thần kinh", Symptom = "Đang chờ cập nhập!", NumberId = 29 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital iodine-deficiency syndrome, myxoedematous type", VietnameseName = "Hội chứng thiếu iod bẩm sinh, thể phù niêm", Symptom = "Đang chờ cập nhập!", NumberId = 29 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital iodine-deficiency syndrome, mixed type", VietnameseName = "Hội chứng thiếu iod bẩm sinh,-thể phối hợp", Symptom = "Đang chờ cập nhập!", NumberId = 29 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital iodine-deficiency syndrome, unspecified", VietnameseName = "Hội chứng thiếu iod bẩm sinh, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 29 },

                 /// chapter 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 36 Những bệnh thiếu dinh dưỡng khác
                 // Number 30
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitamin A deficiency", VietnameseName = "Thiếu vitamin A", Symptom = "Đang chờ cập nhập!", NumberId = 30 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitamin A deficiency with conjunctival xerosis", VietnameseName = "Thiếu vitamin A có khô kết mạc", Symptom = "Đang chờ cập nhập!", NumberId = 30 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitamin A deficiency with Bitot s spot and conjunctival xerosis", VietnameseName = "thiếu vitaminA có vết Bitot và khô kết mạc", Symptom = "Đang chờ cập nhập!", NumberId = 30 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitamin A deficiency with corneal xerosis", VietnameseName = "Khô giác mạc do thiếu vitamin A", Symptom = "Đang chờ cập nhập!", NumberId = 30 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitamin A deficiency with corneal ulceration and xerosis", VietnameseName = "thiếu vitamin A có loét và khô giác mạc", Symptom = "Đang chờ cập nhập!", NumberId = 30 },

                 /// chapter  4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 37 Rối loạn chuyển hóa
                 // Number 31
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of aromatic amino-acid metabolism", VietnameseName = "Rối loạn chuyển hoá acid amin thơm", Symptom = "Đang chờ cập nhập!", NumberId = 31 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Classical phenylketonuria", VietnameseName = "Phenyl-ceton niệu kinh điển", Symptom = "Đang chờ cập nhập!", NumberId = 31 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other hyperphenylalaninaemias", VietnameseName = "Tăng phenylalanin máu khác", Symptom = "Đang chờ cập nhập!", NumberId = 31 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of tyrosine metabolism", VietnameseName = "Rối loạn chuyển hoá tyrosine", Symptom = "Đang chờ cập nhập!", NumberId = 31 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Albinism", VietnameseName = "ChứngBạch tạng", Symptom = "Đang chờ cập nhập!", NumberId = 31 },

                 /// chapter 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 38 Rối loạn các tuyến nội tiết khác
                 // Number 32
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypoparathyroidism", VietnameseName = "Suy cận giáp", Symptom = "Đang chờ cập nhập!", NumberId = 32 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Idiopathic hypoparathyroidism", VietnameseName = "Suy cận giáp không rõ nguyên nhân   ", Symptom = "Đang chờ cập nhập!", NumberId = 32 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pseudohypoparathyroidism", VietnameseName = "Giả Suy cận giáp", Symptom = "Đang chờ cập nhập!", NumberId = 32 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other hypoparathyroidism", VietnameseName = "Suy cận giáp khác", Symptom = "Đang chờ cập nhập!", NumberId = 32 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypoparathyroidism, unspecified", VietnameseName = "Suy cận giáp, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 32 },

                 /// chapter 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa 
                 // Group 39 Đái tháo đường
                 // Number 33
                 new Disease { DiseaseId = ++_dID, EnglishName = "Insuline-dependent diabetes mellitus", VietnameseName = "Bệnh đái tháo đường phụ thuộc insuline", Symptom = "Đang chờ cập nhập!", NumberId = 33 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Insuline-dependent diabetes mellitus (With coma)", VietnameseName = "Bệnh đái tháo đường phụ thuộc insuline (Có hôn mê)", Symptom = "Đang chờ cập nhập!", NumberId = 33 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Insuline-dependent diabetes mellitus (With ketoacidosis)", VietnameseName = "Bệnh đái tháo đường phụ thuộc insuline (Có Nhiễm toan ceton)", Symptom = "Đang chờ cập nhập!", NumberId = 33 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Insuline-dependent diabetes mellitus (With renal complications)", VietnameseName = "Bệnh đái tháo đường phụ thuộc insuline (Có biến chứng thận)", Symptom = "Đang chờ cập nhập!", NumberId = 33 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Insuline-dependent diabetes mellitus (With ophthalmic complications)", VietnameseName = "Bệnh đái tháo đường phụ thuộc insuline(Có biến chứng mắt)", Symptom = "Đang chờ cập nhập!", NumberId = 33 },

                 /// chapter 4 Bệnh nội tiết, dinh dưỡng và chuyển hóa
                 // Group 40 Béo phì-tình trạng thừa cân khác
                 // Number 34
                 new Disease { DiseaseId = ++_dID, EnglishName = "Localized adiposity", VietnameseName = "Béo phì khu trú", Symptom = "Đang chờ cập nhập!", NumberId = 34 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Obesity", VietnameseName = "Bệnh béo phì", Symptom = "Đang chờ cập nhập!", NumberId = 34 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Obesity due to excess calories", VietnameseName = "Béo phì do thừa calo", Symptom = "Đang chờ cập nhập!", NumberId = 34 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Drug-induced obesity", VietnameseName = "Béo phì do thuốc", Symptom = "Đang chờ cập nhập!", NumberId = 34 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Extreme obesity with alveolar hypoventilation", VietnameseName = "Béo phì quá mức với giảm thông khí phế nang", Symptom = "Đang chờ cập nhập!", NumberId = 34 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 41 Rối loạn khí sắc[cảm xúc]
                 // Number 35
                 new Disease { DiseaseId = ++_dID, EnglishName = "Manic episode", VietnameseName = "Giai đoạn hưng cảm", Symptom = "Đang chờ cập nhập!", NumberId = 35 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypomania", VietnameseName = "Hưng cảm nhẹ", Symptom = "Đang chờ cập nhập!", NumberId = 35 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mania without psychotic symptoms", VietnameseName = "Hưng cảm không có các triệu chứng loạn thần", Symptom = "Đang chờ cập nhập!", NumberId = 35 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mania with psychotic symptoms", VietnameseName = "Hưng cảm với các triệu chứng loạn thần", Symptom = "Đang chờ cập nhập!", NumberId = 35 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other manic episodes", VietnameseName = "Các giai đoạn hưng cảm khác", Symptom = "Đang chờ cập nhập!", NumberId = 35 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 42 Các rội loạn bệnh tâm căn có liên quan đến streess  và rối loạn dạng cơ thể
                 // Number 36
                 new Disease { DiseaseId = ++_dID, EnglishName = "Phobic anxiety disorders", VietnameseName = "Rối loạn lo âu ám ảnh sợ hãi", Symptom = "Đang chờ cập nhập!", NumberId = 36 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Agoraphobia", VietnameseName = "Ám ảnh sợ khoảng trống", Symptom = "Đang chờ cập nhập!", NumberId = 36 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Social phobias", VietnameseName = "Ám ảnh sợ xã hội", Symptom = "Đang chờ cập nhập!", NumberId = 36 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Specific (isolated) phobias", VietnameseName = "Ám ảnh sợ đặc hiệu (riêng lẻ", Symptom = "Đang chờ cập nhập!", NumberId = 36 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other phobic anxiety disorders", VietnameseName = "Các rối loạn lo âu ám ảnh sợ khác", Symptom = "Đang chờ cập nhập!", NumberId = 36 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 43 Tâm thần phân liệt,rối loạn loại phân biệt và các rối loạn hoan tưởng
                 // Number 37
                 new Disease { DiseaseId = ++_dID, EnglishName = "Schizophrenia", VietnameseName = "Tâm thần phân liệt", Symptom = "Đang chờ cập nhập!", NumberId = 37 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Paranoid schizophrenia", VietnameseName = "Tâm thần phân liệt thể paranoid", Symptom = "Đang chờ cập nhập!", NumberId = 37 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hebephrenic schizophrenia", VietnameseName = "Tâm thần phân liệt thể thanh xuân", Symptom = "Đang chờ cập nhập!", NumberId = 37 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Catatonic schizophrenia", VietnameseName = "Tâm thần phân liệt thể căng trương lực", Symptom = "Đang chờ cập nhập!", NumberId = 37 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Undifferentiated schizophrenia", VietnameseName = "Tâm thần phân liệt thể không biệt định", Symptom = "Đang chờ cập nhập!", NumberId = 37 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 44 Rối loạn tâm thần và hành vi sử dụng chất tác động tâm thần
                 // Number 38
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mental and behavioural disorders due to use of alcohol", VietnameseName = "Rối loạn tâm thần và hành vi do sử dụng rượu", Symptom = "Đang chờ cập nhập!", NumberId = 38 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mental and behavioural disorders due to use of alcohol (Acute intoxication)", VietnameseName = "Rối loạn tâm thần và hành vi do sử dụng rượu (Nhiễm độc cấp)", Symptom = "Đang chờ cập nhập!", NumberId = 38 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mental and behavioural disorders due to use of alcohol (Harmful use)", VietnameseName = "Rối loạn tâm thần và hành vi do sử dụng rượu (Sử dụng gây hại)", Symptom = "Đang chờ cập nhập!", NumberId = 38 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mental and behavioural disorders due to use of alcohol (Dependence syndrome)", VietnameseName = "Rối loạn tâm thần và hành vi do sử dụng rượu (Hội chứng nghiện)", Symptom = "Đang chờ cập nhập!", NumberId = 38 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mental and behavioural disorders due to use of alcohol (Withdrawal state)", VietnameseName = "Rối loạn tâm thần và hành vi do sử dụng rượu (Trạng thái cai)", Symptom = "Đang chờ cập nhập!", NumberId = 38 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 45 Chậm phát triển tâm thần
                 // Number 39
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mild mental retardation", VietnameseName = "Chậm phát triển tâm thần nhẹ", Symptom = "Đang chờ cập nhập!", NumberId = 39 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Moderate mental retardation", VietnameseName = "Chậm phát triển tâm thần trung bình", Symptom = "Đang chờ cập nhập!", NumberId = 39 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Severe mental retardation", VietnameseName = "Chậm phát triển tâm thần nặng", Symptom = "Đang chờ cập nhập!", NumberId = 39 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Profound mental retardation   ", VietnameseName = "Chậm phát triển tâm thần nghiêm trọng", Symptom = "Đang chờ cập nhập!", NumberId = 39 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other mental retardation", VietnameseName = "Chậm phát triển tâm thần khác", Symptom = "Đang chờ cập nhập!", NumberId = 39 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 46 Các rối loạn phát triển về tâm lý
                 // Number 40
                 new Disease { DiseaseId = ++_dID, EnglishName = "Specific developmental disorders of speech and language", VietnameseName = "Các rối loạn đặc hiệu về phát triển lời nói và ngôn ngữ", Symptom = "Đang chờ cập nhập!", NumberId = 40 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Specific speech articulation disorder", VietnameseName = "Rối loạn đặc hiệu trong sự kết âm", Symptom = "Đang chờ cập nhập!", NumberId = 40 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Expressive language disorder", VietnameseName = "Rối loạn ngôn ngữ biểu hiện", Symptom = "Đang chờ cập nhập!", NumberId = 40 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Receptive language disorder", VietnameseName = "Rối loạn ngôn ngữ tiếp nhận", Symptom = "Đang chờ cập nhập!", NumberId = 40 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acquired aphasia with epilepsy [Landau-Kleffner]", VietnameseName = "Vong ngôn mắc phải với động kinh [Landau-Kleffner]", Symptom = "Đang chờ cập nhập!", NumberId = 40 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 47 Hội chứng hành vi kết hợp với rối loạn sinh lý và nhân tố cơ thể
                 // Number 41
                 new Disease { DiseaseId = ++_dID, EnglishName = "Eating disorders", VietnameseName = "Các rối loạn ăn uống", Symptom = "Đang chờ cập nhập!", NumberId = 41 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anorexia nervosa", VietnameseName = "Chán ăn tâm thần", Symptom = "Đang chờ cập nhập!", NumberId = 41 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atypical anorexia nervosa", VietnameseName = "Chán ăn tâm thần không điển hình", Symptom = "Đang chờ cập nhập!", NumberId = 41 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atypical bulimia nervosa", VietnameseName = "Ăn vô độ tâm thần không điển hình", Symptom = "Đang chờ cập nhập!", NumberId = 41 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Overeating associated with other psychological disturbances", VietnameseName = "Chứng ăn nhiều kết hợp với các rối loạn tâm lý khác", Symptom = "Đang chờ cập nhập!", NumberId = 41 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 48 Các rối loạn hành vi và cảm xúc thường khởi phát ở tuổi trẻ em và thanh thiếu niên
                 // Number 42
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hyperkinetic disorders", VietnameseName = "Các rối loạn tăng động", Symptom = "Đang chờ cập nhập!", NumberId = 42 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disturbance of activity and attention", VietnameseName = "Rối loạn của hoạt động và chú ý", Symptom = "Đang chờ cập nhập!", NumberId = 42 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hyperkinetic conduct disorder", VietnameseName = "Rối loạn hành vi tăng động", Symptom = "Đang chờ cập nhập!", NumberId = 42 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other hyperkinetic disorders", VietnameseName = "Rối loạn tăng động khác", Symptom = "Đang chờ cập nhập!", NumberId = 42 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hyperkinetic disorder, unspecified", VietnameseName = "Rối loạn tăng động, không biệt định", Symptom = "Đang chờ cập nhập!", NumberId = 42 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 49 rối loạn tâm thần không biệt định
                 // Number 43
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mental disorder, not otherwise specified", VietnameseName = "Rối loạn tâm thần không biệt định khác", Symptom = "Đang chờ cập nhập!", NumberId = 43 },


                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 50 Rối loạn nhân cách và hành vi ở người trưởng thành
                 // Number 44
                 new Disease { DiseaseId = ++_dID, EnglishName = "Specific personality disorders", VietnameseName = "Rối loạn nhân cách đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 44 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Paranoid personality disorder", VietnameseName = "Rối loạn nhân cách paranoid", Symptom = "Đang chờ cập nhập!", NumberId = 44 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Schizoid personality disorder", VietnameseName = "Rối loạn nhân cách dạng phân liệt", Symptom = "Đang chờ cập nhập!", NumberId = 44 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dissocial personality disorder", VietnameseName = "Rối loạn nhân cách chống đối xã hội", Symptom = "Đang chờ cập nhập!", NumberId = 44 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Emotionally unstable personality disorder", VietnameseName = "Rối loạn nhân cách cảm xúc không ổn định", Symptom = "Đang chờ cập nhập!", NumberId = 44 },

                 /// chapter 5 Rối loạn tâm thần và hành vi
                 // Group 51 Rối loạn tâm thần thực tổn bao gồm rối loạn tâm thần triệu chứng
                 // Number 45
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dementia in Alzheimer s disease G30.-", VietnameseName = "Mất trí trong bệnh Alzheimer (G30.-†)", Symptom = "Đang chờ cập nhập!", NumberId = 45 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dementia in Alzheimer s disease with early onset G30.0", VietnameseName = "Mất trí trong bệnh Alzheimer khởi phát sớm (G30.0†)", Symptom = "Đang chờ cập nhập!", NumberId = 45 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dementia in Alzheimer s disease with late onsetG30.1", VietnameseName = "Mất trí trong bệnh Alzheimer khởi phát muộn (G30.1†)", Symptom = "Đang chờ cập nhập!", NumberId = 45 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dementia in Alzheimer s disease, atypical or mixed typeG30.8", VietnameseName = "Mất trí trong bệnh Alzheimer, thể không điển hình hoặc thể hỗn hợp (G30.8†)", Symptom = "Đang chờ cập nhập!", NumberId = 45 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dementia in Alzheimer s disease, unspecified G30.9", VietnameseName = "Mất trí trong bệnh Alzheimer, không xác định (G30.9†)", Symptom = "Đang chờ cập nhập!", NumberId = 45 },

                 /// chapter 6 Bệnh hệ thần kinh
                 // Group 52 Bệnh mất myelin của hệ thần kinh trung ương
                 // Number 46
                 new Disease { DiseaseId = ++_dID, EnglishName = "Multiple sclerosis", VietnameseName = "Xơ cứng rải rác", Symptom = "Đang chờ cập nhập!", NumberId = 46 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other acute disseminated demyelination", VietnameseName = "Mất myelin rải rác cấp tính khác", Symptom = "Đang chờ cập nhập!", NumberId = 46 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Neuromyelitis optica [Devic]", VietnameseName = "Viêm tuỷ thị thần kinh [Devic]", Symptom = "Đang chờ cập nhập!", NumberId = 46 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute and subacute haemorrhagic leukoencephalitis [Hurst]", VietnameseName = "Viêm não chất trắng chảy máu cấp và bán cấp", Symptom = "Đang chờ cập nhập!", NumberId = 46 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other specified acute disseminated demyelination", VietnameseName = "Mất myelin rải rác cấp tính xác định khác", Symptom = "Đang chờ cập nhập!", NumberId = 46 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 53 Bệnh chu kì và kịch phát
                 // Number 47
                 new Disease { DiseaseId = ++_dID, EnglishName = "Epilepsy", VietnameseName = "Động kinh", Symptom = "Đang chờ cập nhập!", NumberId = 47 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Localization-related (focal)(partial) idiopathic epilepsy and epileptic syndromes with seizures of localized onset", VietnameseName = "Động kinh nguyên phát khu trú (cục bộ) (từng phần) và hội chứng động kinh với cơn khởi phát khu trú", Symptom = "Đang chờ cập nhập!", NumberId = 47 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Localization-related (focal)(partial) symptomatic epilepsy and epileptic syndromes with simple partial seizures", VietnameseName = "Động kinh triệu chứng có khu trú (cục bộ) (từng phần) và hội chứng động kinh có cơn cục bộ đơn giản", Symptom = "Đang chờ cập nhập!", NumberId = 47 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Localization-related (focal)(partial) symptomatic epilepsy and epileptic syndromes with complex partial seizures", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 47 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Generalized idiopathic epilepsy and epileptic syndromes", VietnameseName = "Hội chứng động kinh và động kinh toàn thể nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 47 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 54 Bệnh dây rễ và đám rối thần kinh
                 // Number 48 
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of trigeminal nerve", VietnameseName = "Bệnh dây thần kinh tam thoa", Symptom = "Đang chờ cập nhập!", NumberId = 48 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Trigeminal neuralgia", VietnameseName = "Đau dây thần kinh tam thoa", Symptom = "Đang chờ cập nhập!", NumberId = 48 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atypical facial pain", VietnameseName = "Đau mặt không điển hình", Symptom = "Đang chờ cập nhập!", NumberId = 48 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of trigeminal nerve", VietnameseName = "Bệnh khác của dây thần kinh tam thoa", Symptom = "Đang chờ cập nhập!", NumberId = 48 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorder of trigeminal nerve, unspecified", VietnameseName = "Bệnh dây thần kinh tam thoa, chưa phân loại", Symptom = "Đang chờ cập nhập!", NumberId = 48 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 55 Bệnh thoái hóa khác của hệ thần kinh
                 // Number 49
                 new Disease { DiseaseId = ++_dID, EnglishName = "Alzheimer s disease", VietnameseName = "Bệnh Alzheimer", Symptom = "Đang chờ cập nhập!", NumberId = 49 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Alzheimer s disease with early onset", VietnameseName = "Bệnh Alzheimer khởi phát sớm", Symptom = "Đang chờ cập nhập!", NumberId = 49 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Alzheimer s disease with late onset", VietnameseName = "Bệnh Alzheimer khởi phát muộn", Symptom = "Đang chờ cập nhập!", NumberId = 49 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other Alzheimer s disease", VietnameseName = "Bệnh Alzheimer khác", Symptom = "Đang chờ cập nhập!", NumberId = 49 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Alzheimer s disease, unspecified", VietnameseName = "Bệnh Alzheimer không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 49 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 56 bệnh viêm hệ thần kinh trung ương
                 // Number 50
                 new Disease { DiseaseId = ++_dID, EnglishName = "Bacterial meningitis, not elsewhere classified", VietnameseName = "Viêm màng não vi khuẩn, không phân loại nơi khác", Symptom = "Đang chờ cập nhập!", NumberId = 50 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Haemophilus meningitis", VietnameseName = "Viêm màng não do Haemophilus", Symptom = "Đang chờ cập nhập!", NumberId = 50 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pneumococcal meningitis", VietnameseName = "Viêm màng não do phế cầu", Symptom = "Đang chờ cập nhập!", NumberId = 50 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Streptococcal meningitis", VietnameseName = "Viêm màng não do liên cầu", Symptom = "Đang chờ cập nhập!", NumberId = 50 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Staphylococcal meningitis", VietnameseName = "Viêm màng não do tụ cầu", Symptom = "Đang chờ cập nhập!", NumberId = 50 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 57 Các bệnh khác của hệ thần kinh
                 // Number 51 
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of autonomic nervous system", VietnameseName = "Bệnh hệ thần kinh tự động", Symptom = "Đang chờ cập nhập!", NumberId = 51 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Idiopathic peripheral autonomic neuropathy", VietnameseName = "Bệnh thần kinh tự động ngoại vi nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 51 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Familial dysautonomia [Riley-Day]", VietnameseName = "Rối loạn thần kinh tự động gia đình [Riley-Day]", Symptom = "Đang chờ cập nhập!", NumberId = 51 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Horner s syndrome", VietnameseName = "Hội chứng Horner", Symptom = "Đang chờ cập nhập!", NumberId = 51 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Multi-system degeneration", VietnameseName = "Thoái hoá đa hệ", Symptom = "Đang chờ cập nhập!", NumberId = 51 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 58 Viên nhiều dây thần kinh và bệnh hệ thần kinh ngoại biên khác
                 // Number 52
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hereditary and idiopathic neuropathy", VietnameseName = "Bệnh dây thần kinh di truyền và nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 52 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hereditary motor and sensory neuropathy", VietnameseName = "Bệnh dây thần kinh cảm giác và vận động di truyền", Symptom = "Đang chờ cập nhập!", NumberId = 52 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Refsum s disease", VietnameseName = "Bệnh Refsum", Symptom = "Đang chờ cập nhập!", NumberId = 52 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Neuropathy in association with hereditary ataxia", VietnameseName = "Bệnh dây thần kinh kết hợp với thất điều di truyền", Symptom = "Đang chờ cập nhập!", NumberId = 52 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Idiopathic progressive neuropathy", VietnameseName = "Bệnh dây thần kinh tiến triển nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 52 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 59 Bệnh của khớp thần kinh - cơ và cơ
                 // Number 53
                 new Disease { DiseaseId = ++_dID, EnglishName = "Myasthenia gravis and other myoneural disorders", VietnameseName = "Nhược cơ và bệnh thần kinh - cơ khác", Symptom = "Đang chờ cập nhập!", NumberId = 53 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Myasthenia gravis", VietnameseName = "Nhược cơ", Symptom = "Đang chờ cập nhập!", NumberId = 53 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Toxic myoneural disorders", VietnameseName = "Bệnh thần kinh - cơ do nhiễm độc", Symptom = "Đang chờ cập nhập!", NumberId = 53 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital and developmental myasthenia", VietnameseName = "Nhược cơ bẩm sinh và trong quá trình phát triển", Symptom = "Đang chờ cập nhập!", NumberId = 53 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other specified myoneural disorders", VietnameseName = "Bệnh thần kinh - cơ xác định khác", Symptom = "Đang chờ cập nhập!", NumberId = 53 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 60 Bại não và những hội chứng tê liệt khác
                 // Number 54
                 new Disease { DiseaseId = ++_dID, EnglishName = "Cerebral palsy", VietnameseName = "Bại não", Symptom = "Đang chờ cập nhập!", NumberId = 54 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Spastic quadriplegic cerebral palsy", VietnameseName = "Bại não liệt tứ chi co cứng", Symptom = "Đang chờ cập nhập!", NumberId = 54 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Spastic diplegic cerebral palsy", VietnameseName = "Bại não liệt co cứng hai bên", Symptom = "Đang chờ cập nhập!", NumberId = 54 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Spastic hemiplegic cerebral palsy", VietnameseName = "Bại não liệt nửa người co cứng", Symptom = "Đang chờ cập nhập!", NumberId = 54 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Dyskinetic cerebral palsy", VietnameseName = "Bại não loạn động", Symptom = "Đang chờ cập nhập!", NumberId = 54 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 61 Hội chứng ngoại pháp và rối loạn vận động
                 // Number 55
                 new Disease { DiseaseId = ++_dID, EnglishName = "Parkinson disease", VietnameseName = "Bệnh Parkinson", Symptom = "Đang chờ cập nhập!", NumberId = 55 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Secondary parkinsonism", VietnameseName = "Hội chứng Parkinson thứ phát", Symptom = "Đang chờ cập nhập!", NumberId = 55 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Malignant neuroleptic syndrome", VietnameseName = "Hội chứng an thần kinh ác tính", Symptom = "Đang chờ cập nhập!", NumberId = 55 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other drug-induced secondary parkinsonism", VietnameseName = "Hội chứng Parkinson thứ phát khác do thuốc", Symptom = "Đang chờ cập nhập!", NumberId = 55 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Secondary parkinsonism due to other external agents", VietnameseName = "Hội chứng Parkinson thứ phát do tác nhân bên ngoài khác", Symptom = "Đang chờ cập nhập!", NumberId = 55 },

                 /// chapter 6 Bệnh hệ thần kinh 
                 // Group 62 Bệnh teo hệ thống ảnh hưởng chủ yếu tới hệ thần kinh trung ương
                 // Number 56
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hungtington disease", VietnameseName = "Bệnh Hungtington", Symptom = "Đang chờ cập nhập!", NumberId = 56 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hereditary ataxia", VietnameseName = "Thất điều di truyền", Symptom = "Đang chờ cập nhập!", NumberId = 56 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Congenital nonprogressive ataxia", VietnameseName = "Thất điều bẩm sinh không tiến triển", Symptom = "Đang chờ cập nhập!", NumberId = 56 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Early-onset cerebellar ataxia", VietnameseName = "Thất điều tiểu não khởi phát sớm", Symptom = "Đang chờ cập nhập!", NumberId = 56 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Late-onset cerebellar ataxia", VietnameseName = "Thất điều tiểu não khởi phát muộn", Symptom = "Đang chờ cập nhập!", NumberId = 56 },

                 /// chapter 7 Bệnh mắt và phần phụ 
                 // Group 63 Bệnh thủy tinh thể
                 // Number 57
                 new Disease { DiseaseId = ++_dID, EnglishName = "Senile cataract", VietnameseName = "Đục thủy tinh thể người già", Symptom = "Đang chờ cập nhập!", NumberId = 57 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Senile incipient cataract", VietnameseName = "Đục thủy tinh thể bắt đầu ở người già", Symptom = "Đang chờ cập nhập!", NumberId = 57 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Senile nuclear cataract", VietnameseName = "Đục thủy tinh thể vùng nhân ở người già", Symptom = "Đang chờ cập nhập!", NumberId = 57 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Senile cataract, morgagnian type", VietnameseName = "Đục thủy tinh thể hình thái Morgagni", Symptom = "Đang chờ cập nhập!", NumberId = 57 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other senile cataract", VietnameseName = "Đục thủy tinh thể người già khác", Symptom = "Đang chờ cập nhập!", NumberId = 57 },

                 /// chapter 7 Bệnh mắt và phần phụ 
                 // Group 64 Rối loạn thị giác và mù lòa
                 // Number 58
                 new Disease { DiseaseId = ++_dID, EnglishName = "Visual disturbances", VietnameseName = "Rối loạn thị giác", Symptom = "Đang chờ cập nhập!", NumberId = 58 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Amblyopia ex anopsia", VietnameseName = "Nhược thị do không nhìn", Symptom = "Đang chờ cập nhập!", NumberId = 58 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Subjective visual disturbances", VietnameseName = "Rối loạn thị giác chủ quan", Symptom = "Đang chờ cập nhập!", NumberId = 58 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Diplopia", VietnameseName = "Song thị", Symptom = "Đang chờ cập nhập!", NumberId = 58 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of binocular vision", VietnameseName = "Rối loạn thị giác hai mắt khác", Symptom = "Đang chờ cập nhập!", NumberId = 58 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 65 Bệnh dịch kính và nhãn cầu
                 // Number 59
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of vitreous body", VietnameseName = "Bệnh của dịch kính", Symptom = "Đang chờ cập nhập!", NumberId = 59 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitreous prolapse", VietnameseName = "Phòi dịch kính", Symptom = "Đang chờ cập nhập!", NumberId = 59 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vitreous haemorrhage", VietnameseName = "Xuất huyết dịch kính", Symptom = "Đang chờ cập nhập!", NumberId = 59 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Crystalline deposits in vitreous body", VietnameseName = "Cặn lắng tinh thể trong dịch kính", Symptom = "Đang chờ cập nhập!", NumberId = 59 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other vitreous opacities", VietnameseName = "Vẩn đục dịch kính khác", Symptom = "Đang chờ cập nhập!", NumberId = 59 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 66 Bệnh của kết mạc
                 // Number 60
                 new Disease { DiseaseId = ++_dID, EnglishName = "Conjunctivitis", VietnameseName = "Viêm kết mạc", Symptom = "Đang chờ cập nhập!", NumberId = 60 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mucopurulent conjunctivitis", VietnameseName = "Viêm kết mạc nhầy mủ", Symptom = "Đang chờ cập nhập!", NumberId = 60 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute atopic conjunctivitis", VietnameseName = "Viêm kết mạc dị ứng cấp", Symptom = "Đang chờ cập nhập!", NumberId = 60 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other acute conjunctivitis", VietnameseName = "Viêm kết mạc cấp khác", Symptom = "Đang chờ cập nhập!", NumberId = 60 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute conjunctivitis, unspecified", VietnameseName = "Viêm kết mạc cấp, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 60 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 67 Bệnh mắt và phần phụ
                 // Number 61
                 new Disease { DiseaseId = ++_dID, EnglishName = "Nystagmus and other irregular eye movements", VietnameseName = "Rung giật nhãn cầu và rối loạn vận nhãn khác", Symptom = "Đang chờ cập nhập!", NumberId = 61 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of eye and adnexa", VietnameseName = "Các bệnh khác của mắt và phần phụ", Symptom = "Đang chờ cập nhập!", NumberId = 61 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Anomalies of pupillary function", VietnameseName = "Bất thường chức năng đồng tử", Symptom = "Đang chờ cập nhập!", NumberId = 61 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Ocular pain", VietnameseName = "Nhức mắt", Symptom = "Đang chờ cập nhập!", NumberId = 61 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other specified disorders of eye and adnexa", VietnameseName = "Các bệnh xác định khác của mắt và phần phụ", Symptom = "Đang chờ cập nhập!", NumberId = 61 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 68 Bệnh Glôcôm
                 // Number 62
                 new Disease { DiseaseId = ++_dID, EnglishName = "Glaucoma", VietnameseName = "Glôcôm", Symptom = "Đang chờ cập nhập!", NumberId = 62 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Glaucoma suspect", VietnameseName = "Nghi ngờ glôcôm", Symptom = "Đang chờ cập nhập!", NumberId = 62 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Primary open-angle glaucoma", VietnameseName = "Glôcôm góc mở nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 62 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Primary angle-closure glaucoma", VietnameseName = "Glôcôm góc đóng nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 62 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Glaucoma secondary to eye trauma", VietnameseName = "Glôcôm thứ phát do chấn thương mắt", Symptom = "Đang chờ cập nhập!", NumberId = 62 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 69 Bệnh củng mạc, giác mạc, giống mạc, giống mắt và thể mi
                 // Number 63
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of sclera", VietnameseName = "Bệnh của củng mạc", Symptom = "Đang chờ cập nhập!", NumberId = 63 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Scleritis", VietnameseName = "Viêm củng mạc", Symptom = "Đang chờ cập nhập!", NumberId = 63 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Episcleritis", VietnameseName = "Viêm thượng củng mạc", Symptom = "Đang chờ cập nhập!", NumberId = 63 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of sclera", VietnameseName = "Bệnh khác của củng mạc", Symptom = "Đang chờ cập nhập!", NumberId = 63 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorder of sclera, unspecified", VietnameseName = "Bệnh củng mạc, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 63 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 70 Bệnh vận nhãn, vận nhãn hai mắt điều tiết và khúc xạ
                 // Number 64
                 new Disease { DiseaseId = ++_dID, EnglishName = "Paralytic strabismus", VietnameseName = "Lác liệt", Symptom = "Đang chờ cập nhập!", NumberId = 64 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Third [oculomotor] nerve palsy", VietnameseName = "Liệt dây thần kinh [vận nhãn] III", Symptom = "Đang chờ cập nhập!", NumberId = 64 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Fourth [trochlear] nerve palsy", VietnameseName = "Liệt dây thần kinh [ròng rọc] IV", Symptom = "Đang chờ cập nhập!", NumberId = 64 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Sixth [abducent] nerve palsy", VietnameseName = "Liệt dây thần kinh VI", Symptom = "Đang chờ cập nhập!", NumberId = 64 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Total (external) ophthalmoplegia", VietnameseName = "Liệt vận nhãn (ngoài) toàn bộ", Symptom = "Đang chờ cập nhập!", NumberId = 64 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 71 Bệnh hắc mạc và võng mạc
                 // Number 65
                 new Disease { DiseaseId = ++_dID, EnglishName = "Chorioretinal inflammation", VietnameseName = "Viêm hắc võng mạc", Symptom = "Đang chờ cập nhập!", NumberId = 65 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Focal chorioretinal inflammation", VietnameseName = "Viêm hắc võng mạc khu trú", Symptom = "Đang chờ cập nhập!", NumberId = 65 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disseminated chorioretinal inflammation", VietnameseName = "Viêm hắc võng mạc rải rác", Symptom = "Đang chờ cập nhập!", NumberId = 65 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Posterior cyclitis", VietnameseName = "Viêm thể mi sau", Symptom = "Đang chờ cập nhập!", NumberId = 65 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other chorioretinal inflammations", VietnameseName = "Bệnh viêm hắc võng mạc khác", Symptom = "Đang chờ cập nhập!", NumberId = 65 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 72 Bệnh của mí mắt, lệ bộc và hốc mắt
                 // Number 66
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hordeolum and chalazion", VietnameseName = "Lẹo và chắp", Symptom = "Đang chờ cập nhập!", NumberId = 66 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hordeolum and other deep inflammation of eyelid", VietnameseName = "Lẹo và viêm sâu khác của mí mắt", Symptom = "Đang chờ cập nhập!", NumberId = 66 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Chalazion", VietnameseName = "Chắp", Symptom = "Đang chờ cập nhập!", NumberId = 66 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other inflammation of eyelid", VietnameseName = "Viêm khác của mí mắt", Symptom = "Đang chờ cập nhập!", NumberId = 66 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Blepharitis", VietnameseName = "Viêm bờ mi", Symptom = "Đang chờ cập nhập!", NumberId = 66 },

                 /// chapter 7 Bệnh mắt và phần phụ
                 // Group 73 Bệnh thần kinh thị và đường dẫn thị giác
                 // Number 67
                 new Disease { DiseaseId = ++_dID, EnglishName = "Optic neuritis", VietnameseName = "Viêm thần kinh thị", Symptom = "Đang chờ cập nhập!", NumberId = 67 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other disorders of optic [2nd] nerve and visual pathways", VietnameseName = "Các bệnh khác của thần kinh thị (dây thần kinh II) và đường thị giác", Symptom = "Đang chờ cập nhập!", NumberId = 67 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Disorders of optic nerve, not elsewhere classified", VietnameseName = "Bệnh thần kinh thị, không phân loại nơi khác", Symptom = "Đang chờ cập nhập!", NumberId = 67 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Papilloedema, unspecified", VietnameseName = "Phù gai, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 67 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Optic atrophy", VietnameseName = "Teo thần kinh thị", Symptom = "Đang chờ cập nhập!", NumberId = 67 },

                 /// chapter 8 Bệnh của tai và xương chũm
                 // Group 74 Bệnh của tai ngoài
                 // Number 68
                 new Disease { DiseaseId = ++_dID, EnglishName = "Otitis externa", VietnameseName = "Viêm tai ngoài", Symptom = "Đang chờ cập nhập!", NumberId = 68 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Abscess of external ear", VietnameseName = "Apxe tai ngoài", Symptom = "Đang chờ cập nhập!", NumberId = 68 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Cellulitis of external ear", VietnameseName = "Viêm mô tế bào tai ngoài", Symptom = "Đang chờ cập nhập!", NumberId = 68 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Malignant otitis externa", VietnameseName = "Viêm tai ngoài ác tính", Symptom = "Đang chờ cập nhập!", NumberId = 68 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other infective otitis externa", VietnameseName = "Viêm tai ngoài nhiễm trùng khác", Symptom = "Đang chờ cập nhập!", NumberId = 68 },

                 /// chapter 8 Bệnh của tai và xương chũm
                 // Group 75 Bệnh của tai giữa và xương chũm
                 // Number 69
                 new Disease { DiseaseId = ++_dID, EnglishName = "Nonsuppurative otitis media", VietnameseName = "Viêm tai giữa không nung mủ viêm tai giữa không mủ", Symptom = "Đang chờ cập nhập!", NumberId = 69 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute serous otitis media", VietnameseName = "Viêm tai giữa xuất tiết cấp và bán cấp viêm tai giữa thanh dịch cấp", Symptom = "Đang chờ cập nhập!", NumberId = 69 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other acute nonsuppurative otitis media", VietnameseName = "Viêm tai giữa không nung mủ cấp khác", Symptom = "Đang chờ cập nhập!", NumberId = 69 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Chronic serous otitis media", VietnameseName = "Viêm tai giữa xuất tiết mạn viêm tai giữa thanh dịch mạn", Symptom = "Đang chờ cập nhập!", NumberId = 69 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Chronic mucoid otitis media", VietnameseName = "Viêm tai giữa tiết nhày mạn", Symptom = "Đang chờ cập nhập!", NumberId = 69 },

                 /// chapter 8 Bệnh của tai và xương chũm
                 // Group 76 Bệnh khác của tai
                 // Number 70
                 new Disease { DiseaseId = ++_dID, EnglishName = "Conductive and sensorineural hearing loss", VietnameseName = "Điếc dẫn truyền và điếc thần kinh giác quan điếc dẫn truyền và tiếp nhận", Symptom = "Đang chờ cập nhập!", NumberId = 70 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Conductive hearing loss, bilateral", VietnameseName = "Điếc dẫn truyền hai bên", Symptom = "Đang chờ cập nhập!", NumberId = 70 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Conductive hearing loss, unilateral with unrestricted hearing on the contralateral side", VietnameseName = "Điếc dẫn truyền một bên với sức nghe không hạn chế bên đối diện", Symptom = "Đang chờ cập nhập!", NumberId = 70 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Conductive hearing loss, unspecified", VietnameseName = "Điếc dẫn truyền không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 70 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Sensorineural hearing loss, bilateral", VietnameseName = "Điếc thần kinh hai bên điếc tiếp nhận hai bên", Symptom = "Đang chờ cập nhập!", NumberId = 70 },

                 /// chapter 8 Bệnh của tai và xương chũm
                 // Group 77 Bệnh của tai trong
                 // Number 71
                 new Disease { DiseaseId = ++_dID, EnglishName = "Otosclerosis", VietnameseName = "Xốp xơ tai", Symptom = "Đang chờ cập nhập!", NumberId = 71 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Otosclerosis involving oval window, nonobliterative", VietnameseName = "Xốp xơ tai xâm lấn cửa sổ bầu dục làm bít tắc xốp xơ tai xâm lấn cửa sổ bầu dục bít lấp", Symptom = "Đang chờ cập nhập!", NumberId = 71 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Cochlear otosclerosis", VietnameseName = "Xốp xơ ốc tai", Symptom = "Đang chờ cập nhập!", NumberId = 71 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other otosclerosis", VietnameseName = "Xốp xơ tai khác", Symptom = "Đang chờ cập nhập!", NumberId = 71 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Otosclerosis, unspecified", VietnameseName = "Xơ nhĩ không đặc hiệu xốp xơ tai không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 71 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 78 Thể bệnh tim khác
                 // Number 72
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute pericarditis", VietnameseName = "Viêm màng ngoài tim cấp", Symptom = "Đang chờ cập nhập!", NumberId = 72 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute nonspecific idiopathic pericarditis", VietnameseName = "Viêm màng ngoài tim cấp, không rõ nguyên nhân, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 72 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Infective pericarditis", VietnameseName = "Viêm màng ngoài tim nhiễm trùng", Symptom = "Đang chờ cập nhập!", NumberId = 72 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other forms of acute pericarditis", VietnameseName = "Các thể khác của viêm màng ngoài tim cấp", Symptom = "Đang chờ cập nhập!", NumberId = 72 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute pericarditis, unspecified", VietnameseName = "Viêm màng ngoài tim cấp, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 72 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 79 bệnh tim thiếu máu cục bộ
                 // Number 73
                 new Disease { DiseaseId = ++_dID, EnglishName = "Angina pectoris", VietnameseName = "Cơn đau thắt ngực", Symptom = "Đang chờ cập nhập!", NumberId = 73 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Unstable angina", VietnameseName = "Cơn đau thắt ngực không ổn định", Symptom = "Đang chờ cập nhập!", NumberId = 73 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Angina pectoris with documented spasm", VietnameseName = "Cơn đau thắt ngực do co thắt mạch", Symptom = "Đang chờ cập nhập!", NumberId = 73 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other forms of angina pectoris", VietnameseName = "Dạng khác của cơn đau thắt ngực", Symptom = "Đang chờ cập nhập!", NumberId = 73 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Angina pectoris, unspecified", VietnameseName = "Cơn đau thắt ngực, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 73 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 80 Bệnh lý tăng huyết áp
                 // Number 74
                 new Disease { DiseaseId = ++_dID, EnglishName = "Essential (primary) hypertension", VietnameseName = "Bệnh Tăng huyết áp vô căn (nguyên phát)", Symptom = "Đang chờ cập nhập!", NumberId = 74 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypertensive heart disease", VietnameseName = "Bệnh tim do tăng huyết áp", Symptom = "Đang chờ cập nhập!", NumberId = 74 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypertensive heart disease with (congestive) heart failure", VietnameseName = "Bệnh tim do tăng huyết áp, có suy tim (sung huyết)", Symptom = "Đang chờ cập nhập!", NumberId = 74 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypertensive heart disease without (congestive) heart failure", VietnameseName = "Bệnh tim do tăng huyết áp, không suy tim (sung huyết)", Symptom = "Đang chờ cập nhập!", NumberId = 74 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypertensive renal disease", VietnameseName = "Bệnh thận do tăng huyết áp", Symptom = "Đang chờ cập nhập!", NumberId = 74 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 81 Bệnh tĩnh mạch, mạch bạch huyết hạch bạch huyết không phân loại nơi khác
                 // Number 75
                 new Disease { DiseaseId = ++_dID, EnglishName = "Phlebitis and thrombophlebitis", VietnameseName = "Viêm tĩnh mạch và tắc tĩnh mạch", Symptom = "Đang chờ cập nhập!", NumberId = 75 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Phlebitis and thrombophlebitis of superficial vessels of lower extremities", VietnameseName = "Viêm tĩnh mạch và viêm tắc tĩnh mạch nông ở chi dưới", Symptom = "Đang chờ cập nhập!", NumberId = 75 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Phlebitis and thrombophlebitis of femoral vein", VietnameseName = "Viêm tĩnh mạch và viêm tắc tĩnh mạch đùi", Symptom = "Đang chờ cập nhập!", NumberId = 75 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Phlebitis and thrombophlebitis of other deep vessels of lower extremities", VietnameseName = "Viêm tĩnh mạch và viêm tắc tĩnh mạch của các tĩnh mạch sâu khác ở chi dưới", Symptom = "Đang chờ cập nhập!", NumberId = 75 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Phlebitis and thrombophlebitis of lower extremities, unspecified", VietnameseName = "Viêm tĩnh mạch và viêm tắc tĩnh mạch ở chi dưới, không đặc hiệu", Symptom = "Đang chờ cập nhập!", NumberId = 75 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 82 thấp khớp cấp
                 // Number 76
                 new Disease { DiseaseId = ++_dID, EnglishName = "Rheumatic fever without mention of I00 heart involvement", VietnameseName = "Thấp không có tổn thương tim", Symptom = "Đang chờ cập nhập!", NumberId = 76 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Rheumatic fever with heart involvement", VietnameseName = "Thấp ảnh hưởng đến tim", Symptom = "Đang chờ cập nhập!", NumberId = 76 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute rheumatic pericarditis", VietnameseName = "Viêm màng ngoài tim do thấp cấp", Symptom = "Đang chờ cập nhập!", NumberId = 76 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute rheumatic endocarditis", VietnameseName = "Viêm nội tâm mạc cấp do thấp", Symptom = "Đang chờ cập nhập!", NumberId = 76 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute rheumatic myocarditis", VietnameseName = "Viêm cơ tim do thấp cấp", Symptom = "Đang chờ cập nhập!", NumberId = 76 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 83 Bệnh tim do phổi và bệnh tuần hoàn phổi
                 // Number 77
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pulmonary embolism", VietnameseName = "Tắc mạch phổi", Symptom = "Đang chờ cập nhập!", NumberId = 77 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pulmonary embolism with mention of acute cor pulmonale", VietnameseName = "Thuyên tắc phổi có tâm phế cấp", Symptom = "Đang chờ cập nhập!", NumberId = 77 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pulmonary embolism without mention of acute cor pulmonale", VietnameseName = "Thuyên tắc phổi không có tâm phế cấp", Symptom = "Đang chờ cập nhập!", NumberId = 77 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other pulmonary heart diseases", VietnameseName = "Các bệnh tim do phổi khác", Symptom = "Đang chờ cập nhập!", NumberId = 77 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Primary pulmonary hypertension", VietnameseName = "Tăng áp động mạch phổi nguyên phát", Symptom = "Đang chờ cập nhập!", NumberId = 77 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 84 Bệnh động mạch, tiểu động mạch và mao mạch
                 // Number 78
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atherosclerosis", VietnameseName = "Xơ vữa động mạch", Symptom = "Đang chờ cập nhập!", NumberId = 78 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atherosclerosis of aorta", VietnameseName = "Xơ vữa động mạch chủ", Symptom = "Đang chờ cập nhập!", NumberId = 78 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atherosclerosis of renal artery", VietnameseName = "Xơ vữa động mạch thận", Symptom = "Đang chờ cập nhập!", NumberId = 78 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atherosclerosis of arteries of extremities", VietnameseName = "Xơ vữa động mạch ngoại biên", Symptom = "Đang chờ cập nhập!", NumberId = 78 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Atherosclerosis of other arteries", VietnameseName = "Xơ vữa động mạch khác", Symptom = "Đang chờ cập nhập!", NumberId = 78 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 85 Rối loạn khác và không xác định của hệ tuần hoàn
                 // Number 79
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypotension", VietnameseName = "Huyết áp thấp (hạ huyết áp)", Symptom = "Đang chờ cập nhập!", NumberId = 79 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Idiopathic hypotension", VietnameseName = "Hạ huyết áp không rõ nguyên nhân", Symptom = "Đang chờ cập nhập!", NumberId = 79 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Orthostatic hypotension", VietnameseName = "Hạ huyết áp thế đứng", Symptom = "Đang chờ cập nhập!", NumberId = 79 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Hypotension due to drugs", VietnameseName = "Hạ huyết áp do thuốc", Symptom = "Đang chờ cập nhập!", NumberId = 79 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other hypotension", VietnameseName = "Hạ huyết áp khác", Symptom = "Đang chờ cập nhập!", NumberId = 79 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 86 Bệnh mạch máu não
                 // Number 80
                 new Disease { DiseaseId = ++_dID, EnglishName = "Subarachnoid haemorrhage", VietnameseName = "Xuất huyết dưới màng nhện", Symptom = "Đang chờ cập nhập!", NumberId = 80 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Subarachnoid haemorrhage from carotid siphon and bifurcation", VietnameseName = "Xuất huyết dưới màng nhện từ hành cảnh và chỗ chia nhánh động mạch cảnh", Symptom = "Đang chờ cập nhập!", NumberId = 80 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Subarachnoid haemorrhage from middle cerebral artery", VietnameseName = "Xuất huyết dưới nhện từ động mạch não giữa", Symptom = "Đang chờ cập nhập!", NumberId = 80 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Subarachnoid haemorrhage from anterior communicating artery", VietnameseName = "Xuất huyết dưới nhện từ động mạch thông trước", Symptom = "Đang chờ cập nhập!", NumberId = 80 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Subarachnoid haemorrhage from posterior communicating artery", VietnameseName = "Xuất huyết dưới màng nhện từ động mạch thông sau", Symptom = "Đang chờ cập nhập!", NumberId = 80 },

                 /// chapter 9 Bệnh hệ tuần hoàn
                 // Group 87 Bệnh tim mạn tính do thấp
                 // Number 81
                 new Disease { DiseaseId = ++_dID, EnglishName = "Rheumatic mitral valve diseases", VietnameseName = "Bệnh lý van hai lá do thấp", Symptom = "Đang chờ cập nhập!", NumberId = 81 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mitral stenosis", VietnameseName = "Hẹp van hai lá", Symptom = "Đang chờ cập nhập!", NumberId = 81 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Rheumatic mitral insufficiency", VietnameseName = "Hở van hai lá do thấp", Symptom = "Đang chờ cập nhập!", NumberId = 81 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mitral stenosis with insufficiency", VietnameseName = "Hẹp hở van hai lá", Symptom = "Đang chờ cập nhập!", NumberId = 81 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other mitral valve diseases", VietnameseName = "Bệnh van hai lá khác", Symptom = "Đang chờ cập nhập!", NumberId = 81 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 88 Nhiễm trùng đường hô hấp dưới cấp khác
                 // Number 82 
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute bronchitis", VietnameseName = "Viêm phế quản cấp", Symptom = "Đang chờ cập nhập!", NumberId = 82 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute bronchitis due to Mycoplasma pneumoniae", VietnameseName = "Viêm phế quản cấp do Mycoplasma pneumoniae", Symptom = "Đang chờ cập nhập!", NumberId = 82 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute bronchitis due to Haemophilus influenzae", VietnameseName = "Viêm phế quản cấp do Haemophilus lnfluenzae", Symptom = "Đang chờ cập nhập!", NumberId = 82 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute bronchitis due to streptococcus", VietnameseName = "Viêm phế quản cấp do streptococcus  ", Symptom = "Đang chờ cập nhập!", NumberId = 82 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute bronchitis due to coxsackievirus", VietnameseName = "Viêm phế quản cấp do virus coxsackie", Symptom = "Đang chờ cập nhập!", NumberId = 82 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 89  Bệnh hô hấp dưới mạn tính
                 // Number 83
                 new Disease { DiseaseId = ++_dID, EnglishName = "Bronchitis, not specified as acute or chronic", VietnameseName = "Viêm phế quản không xác định được là cấp hay mạn tính", Symptom = "Đang chờ cập nhập!", NumberId = 83 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Simple and mucopurulent chronic bronchitis", VietnameseName = "Viêm phế quản mạn tính đơn thuần và nhầy mủ", Symptom = "Đang chờ cập nhập!", NumberId = 83 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Simple chronic bronchitis", VietnameseName = "Viêm phế quản mạn tính đơn thuần", Symptom = "Đang chờ cập nhập!", NumberId = 83 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mucopurulent chronic bronchitis", VietnameseName = "Viêm phế quản mạn tính nhầy mủ", Symptom = "Đang chờ cập nhập!", NumberId = 83 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Mixed simple and mucopurulent chronic bronchitis", VietnameseName = "Viêm phế quản mạn tính hỗn hợp (đơn thuần và nhầy mủ)", Symptom = "Đang chờ cập nhập!", NumberId = 83 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 90  Cúm và viêm phổi
                 // Number 84
                 new Disease { DiseaseId = ++_dID, EnglishName = "Influenza due to certain identified influenza virus", VietnameseName = "Cúm do virus đã được định danh", Symptom = "Đang chờ cập nhập!", NumberId = 84 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Influenza due to other identified influenza virus", VietnameseName = "Cảm cúm do virus cúm được định danh khác", Symptom = "Đang chờ cập nhập!", NumberId = 84 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Influenza with pneumonia, other influenza virus identified", VietnameseName = "Cảm cúm với viêm phổi, virus cúm được định danh khác", Symptom = "Đang chờ cập nhập!", NumberId = 84 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Influenza with other respiratory manifestations, other influenza virus identified", VietnameseName = "Cảm cúm với biểu hiện hô hấp khác, virus cúm được định", Symptom = "Đang chờ cập nhập!", NumberId = 84 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Influenza with other manifestations, other influenza virus identified", VietnameseName = "Cảm cúm với biểu hiện khác, virus cúm được định danh khác", Symptom = "Đang chờ cập nhập!", NumberId = 84 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 91 Các bệnh hô hấp khác ảnh hưởng chủ yếu đến mô kẽ
                 // Number 85
                 new Disease { DiseaseId = ++_dID, EnglishName = "Adult respiratory distress syndrome", VietnameseName = "Hội chứng suy hô hấp ở người lớn", Symptom = "Đang chờ cập nhập!", NumberId = 85 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pulmonary oedema", VietnameseName = "Phù phổi", Symptom = "Đang chờ cập nhập!", NumberId = 85 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pulmonary eosinophilia, not elsewhere classifed", VietnameseName = "Tăng bạch cầu ái toan ở phổi, chưa được phân loại ở nơi khác", Symptom = "Đang chờ cập nhập!", NumberId = 85 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other interstitial pulmonary diseases", VietnameseName = "Bệnh phổi mô kẽ khác", Symptom = "Đang chờ cập nhập!", NumberId = 85 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Alveolar and parietoalveolar conditions", VietnameseName = "Bệnh lý phế nang và thành phế nang", Symptom = "Đang chờ cập nhập!", NumberId = 85 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 92 Các bệnh khác của đường hô hấp trên
                 // Number 86 
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vasomotor and allergic rhinitis", VietnameseName = "Viêm mũi vận mạch và viêm mũi dị ứng", Symptom = "Đang chờ cập nhập!", NumberId = 86 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Vasomotor rhinitis", VietnameseName = "Viêm mũi vận mạch", Symptom = "Đang chờ cập nhập!", NumberId = 86 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Allergic rhinitis due to pollen", VietnameseName = "Viêm mũi dị ứng phấn hoa", Symptom = "Đang chờ cập nhập!", NumberId = 86 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other seasonal allergic rhinitis", VietnameseName = "Viêm mũi dị ứng theo mùa khác", Symptom = "Đang chờ cập nhập!", NumberId = 86 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Other allergic rhinitis", VietnameseName = "Viêm mũi dị ứng khác", Symptom = "Đang chờ cập nhập!", NumberId = 86 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 93 Các bệnh lý khác của hệ hô hấp
                 // Number 87
                 new Disease { DiseaseId = ++_dID, EnglishName = "Postprocedural respiratory disorders, not elsewhere classified", VietnameseName = "Các bệnh hô hấp sau can thiệp thủ thuật, chưa phân loại nơi khác", Symptom = "Đang chờ cập nhập!", NumberId = 87 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Tracheostomy malfunction", VietnameseName = "Rối loạn chức năng sau khi mở khí quản", Symptom = "Đang chờ cập nhập!", NumberId = 87 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute pulmonary insufficiency following thoracic surgery", VietnameseName = "Hở van động mạch phổi cấp tính sau phẫu thuật lồng ngực", Symptom = "Đang chờ cập nhập!", NumberId = 87 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Acute pulmonary insufficiency following nonthoracic surgery", VietnameseName = "Hở van động mạch phổi cấp tính sau phẫu thuật ngoài lồng ngực", Symptom = "Đang chờ cập nhập!", NumberId = 87 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Chronic pulmonary insufficiency following surgery", VietnameseName = "Hở van động mạch phổi mạn tính sau phẫu thuật", Symptom = "Đang chờ cập nhập!", NumberId = 87 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 94 Bệnh khác của màng phổi
                 // Number 88 
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pleural effusion, not elsewhere classified", VietnameseName = "Tràn dịch màng phổi, không phân loại nơi khác", Symptom = "Đang chờ cập nhập!", NumberId = 88 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pleural effusion incondition classified elsewhere", VietnameseName = "Tràn dịch màng phổi trong bệnh phân loại nơi khác", Symptom = "Đang chờ cập nhập!", NumberId = 88 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pleural plaque", VietnameseName = "Mảng màng phổi", Symptom = "Đang chờ cập nhập!", NumberId = 88 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pleural plaque with presence of asbestos", VietnameseName = "Mảng màng phổi do amian", Symptom = "Đang chờ cập nhập!", NumberId = 88 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Pleural plaque without asbestos", VietnameseName = "Mảng màng phổi không do amian", Symptom = "Đang chờ cập nhập!", NumberId = 88 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 95 Tình trạng nung mủ và hoại tử của đường hô hấp dưới
                 // Number 89
                 new Disease { DiseaseId = ++_dID, EnglishName = "Abscess of lung and mediastinum", VietnameseName = "Áp xe phổi và trung thất", Symptom = "Đang chờ cập nhập!", NumberId = 89 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Gangrene and necrosis of lung", VietnameseName = "Hoại thư và hoại tử ở phổi", Symptom = "Đang chờ cập nhập!", NumberId = 89 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Abscess of lung with pneumonia", VietnameseName = "Áp xe phổi có viêm phổi", Symptom = "Đang chờ cập nhập!", NumberId = 89 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Abscess of lung without pneumonia", VietnameseName = "Áp xe phổi không có viêm phổi", Symptom = "Đang chờ cập nhập!", NumberId = 89 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "Abscess of mediastinum", VietnameseName = "Áp xe trung thất", Symptom = "Đang chờ cập nhập!", NumberId = 89 },
                
                 /// chapter 10 Bệnh Hô hấp
                 // Group 96
                 // Number 90
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 97
                 // Number 91
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 96
                 // Number 90
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 90 },

                 /// chapter 10 Bệnh Hô hấp
                 // Group 97
                 // Number 91
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId = 91 },

                 /// chapter
                 // Group 
                 // Number 
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  92},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  92},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  92},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  92},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  92},

                 /// chapter
                 // Group 
                 // Number 
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  93},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  93},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  93},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  93},
                 new Disease { DiseaseId = ++_dID, EnglishName = "", VietnameseName = "", Symptom = "Đang chờ cập nhập!", NumberId =  93}
             );
        }
    }
}
