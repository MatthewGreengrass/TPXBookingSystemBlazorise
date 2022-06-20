//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TPX.BookingSystem.Data;
//using TPX.BookingSystem.Models;

//namespace TPX.BookingSystem.Data
//{
//    public class ConversationService
//    {
//        private readonly IServiceScope _serviceScope;
//        private readonly ApplicationDbContext _context;

//        public ConversationService(IServiceProvider serviceProvider)
//        {
//            _serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
//            _context = _serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
//        }

//        public Task<List<RequestType>> GetRequestType()
//        {
//            var list = new List<RequestType>
//            {
//                new RequestType() { Name = "Cancellation Request", Value = "Value"},
//                new RequestType() { Name = "Booking Modification Request", Value = "Value1"},
//                new RequestType() { Name = "Additional Booking Preference", Value = "Value2"},
//                new RequestType() { Name = "Query", Value = "Value3"}
//            };

//            return Task.FromResult(list);
//        }

//        public Task<List<AllBookings>> GetAllBookingsList()
//        {
//            var list = new List<AllBookings>
//            {
//                new AllBookings() { ID = 1 },
//                new AllBookings() { ID = 2 },
//                new AllBookings() { ID = 3 },
//                new AllBookings() { ID = 4 }
//            };

//            return Task.FromResult(list);
//        }

//        TrainBookingService TrainBookingService;
//        HotelBookingService HotelBookingService;
//        FlightBookingService FlightBookingService;

//        private List<TrainBooking> TrainBookings;
//        private List<HotelBooking> HotelBookings;
//        private List<FlightBooking> FlightBookings;

//        protected async Task OnInitializedAsync()
//        {
//            TrainBookings = await TrainBookingService.GetTrainBookings();

//            HotelBookings = await HotelBookingService.GetHotelBookings();

//            FlightBookings = await FlightBookingService.GetFlightBookings();

//            List<string> AllBookings = new List<string>();

//            AllBookings.AddRange((IEnumerable<string>)TrainBookings);
//            AllBookings.AddRange((IEnumerable<string>)HotelBookings);
//            AllBookings.AddRange((IEnumerable<string>)FlightBookings);

//        }

//        public void AddConversation(Conversations Conversation)
//        {
//            _context.Add(Conversation);
//            _context.SaveChangesAsync();
//        }
//    }
//}