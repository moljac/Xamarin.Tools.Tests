//using System;
//
//namespace Twilio.IPMessaging
//{
//    internal partial class ChannelListenerEventDispatcher : Java.Lang.Object, IChannelListener
//    {
//        Twilio.IPMessaging.Impl.ChannelImpl sender;
//
//        public ChannelListenerEventDispatcher (Twilio.IPMessaging.Impl.ChannelImpl sender)
//        {
//            this.sender = sender;
//        }
//
//        internal EventHandler<MessageAddedEventArgs> MessageAdded;
//        public void OnMessageAdded (IMessage message)
//        {
//            MessageAdded?.Invoke (sender, new MessageAddedEventArgs { Message = message });
//        }
//
//        internal EventHandler<MessageDeletedEventArgs> MessageDeleted;
//        public void OnMessageDeleted (IMessage message)
//        {
//            MessageDeleted?.Invoke (sender, new MessageDeletedEventArgs { Message = message });
//        }
//
//        internal EventHandler<MessageChangedEventArgs> MessageChanged;
//        public void OnMessageChanged (IMessage message)
//        {
//            MessageChanged?.Invoke (sender, new MessageChangedEventArgs { Message = message });
//        }
//    }
//
//    public class MessageAddedEventArgs : EventArgs
//    {
//        public IMessage Message { get; internal set; }
//    }
//
//    public class MessageDeletedEventArgs : EventArgs
//    {
//        public IMessage Message { get; internal set; }
//    }
//
//    public class MessageChangedEventArgs : EventArgs
//    {
//        public IMessage Message { get; internal set; }
//    }
//}
//
//namespace Twilio.IPMessaging.Impl
//{
//    public partial class ChannelImpl
//    {
//        WeakReference dispatcher;
//        ChannelListenerEventDispatcher EventDispatcher
//        {
//            get
//            {
//                if (dispatcher == null || !dispatcher.IsAlive)
//                {
//                    var d = new ChannelListenerEventDispatcher (this);
//                    SetListener (d);
//                    dispatcher = new WeakReference(d);
//                }
//
//                return (ChannelListenerEventDispatcher) dispatcher.Target;
//            }
//        }
//
//        public event EventHandler<MessageAddedEventArgs> MessageAdded
//        {
//            add { EventDispatcher.MessageAdded += value; }
//            remove { EventDispatcher.MessageAdded -= value; }
//        }
//    }
//}
//
