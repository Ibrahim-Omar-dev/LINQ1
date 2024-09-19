using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityOperations
{
    public static class QuestionBank
    {
        private static Random random = new Random();
        public static Question PickOne()
        {
            return All[random.Next(0, All.Count)];
        }
        public static IEnumerable<Question> Randomize(int count)
        {
            if (All.Count < count) return All;
            return AllShuffled.Take(count);
        }

        public static void ToQuiz(this IEnumerable<Question> questions)
        {
            foreach (var question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine();

            }
        }

        public static List<Question> GetQuestionRange(IEnumerable<int> range)
        {
            return All.Where((x, i) => range.Contains(i)).ToList();
        }

        public static List<Question> All => new List<Question>()
        {
            // Question #1
            new Question
            {
                Title = "Q #1: In the streaming stored audio/video category of audio/video services",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Files are compressed and stored on the server"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "A user listens to a broadcast audio and video through the internet"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "People use the Internet to interactively communicate with one another"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "None of the above"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #2
            new Question
            {
                Title = "Q #2: In the streaming live audio/video category of audio/video services",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Files are compressed and stored on the server"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "A user listens to a broadcast audio and video through the internet"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "People use the Internet to interactively communicate with one another"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "None of the above"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #3
            new Question
            {
                Title = "Q #3: In the interactive audio/video category of audio/video services",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Files are compressed and stored on the server"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "A user listens to a broadcast audio and video through the internet"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "People use the Internet to interactively communicate with one another"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "None of the above"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #4
            new Question
            {
                Title = "Q #4: Streaming stored audio/video is sometimes referred to as on-demand audio/video",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #5
            new Question
            {
                Title = "Q #5: An example of streaming stored audio/video is Internet radio",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #6
            new Question
            {
                Title = "Q #6: Streaming live audio/video refers to on-demand requests for compressed audio/video",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #7
            new Question
            {
                Title = "Q #7: An example of interactive audio/video is Internet teleconferencing",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #8
            new Question
            {
                Title = "Q #8: A raw piece of information, whether audio or video, must be compressed and then digitized",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #9
            new Question
            {
                Title = "Q #9: A raw piece of information, whether audio or video, must be digitized and then compressed",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #10
            new Question
            {
                Title = "Q #10: Digitization refers to",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Conversion to a stream of numbers, and preferably these numbers should be integers for efficiency"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "The process of coding that will effectively reduce the total number of bits needed to represent certain information"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "The process of converting information into an analog format"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Conversion to a stream of numbers, and preferably these numbers should be decimals for efficiency"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #11
            new Question
            {
                Title = "Q #11: Compression refers to",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Conversion to a stream of numbers, and preferably these numbers should be integers for efficiency"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "The process of coding that will effectively reduce the total number of bits needed to represent certain information"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "The process of converting information into an analog format"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Conversion to a stream of numbers, and preferably these numbers should be decimals for efficiency"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #12
            new Question
            {
                Title = "Q #12: Analog frequencies represents the sound frequency as a function of time",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #13
            new Question
            {
                Title = "Q #13: Analog frequencies represents the sound amplitude as a function of time",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #14
            new Question
            {
                Title = "Q #14: To digitize an analog signal, the signal must be sampled in the dimension of time, as well as the dimension of amplitude",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #15
            new Question
            {
                Title = "Q #15: To digitize an analog signal, the signal must be sampled in the dimension of time, as well as the dimension of frequency",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #16
            new Question
            {
                Title = "Q #16: Quantization refers to",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sampling in the voltage dimension"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Sampling in the frequency dimension"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Sampling in the time dimension"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Sampling in the bitrate dimension"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #17
            new Question
            {
                Title = "Q #17: Sampling referes to the process of sampling the time dimension",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #18
            new Question
            {
                Title = "Q #18: Sampling referes to the process of sampling the amplitude dimension",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #19
            new Question
            {
                Title = "Q #19: Nyquist thereom states",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "If the highest frequency of the signal is f, we need to sample the signal 2f times per second"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "If the highest frequency of the signal is f, we need to sample the signal f times per second"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "If the highest frequency of the signal is f, we need to sample the signal 3f times per second"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "If the highest frequency of the signal is f, we need to sample the signal 4f times per second"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #20
            new Question
            {
                Title = "Q #20: The process of converting from analog audio to compressed binary form sampling quantization, and encoding is known as:",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Pulse code modulation"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Polar quantization"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Pulse code quantization"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Polar code modulation"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #21
            new Question
            {
                Title = "Q #21: A video consists of a sequence of frames",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #22
            new Question
            {
                Title = "Q #22: The standard number of frames per second of a video is 25 frames per second",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #23
            new Question
            {
                Title = "Q #23: In North America, a common number of frames per second _________ frames per second",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "20"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "35"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "25"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "30"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #24
            new Question
            {
                Title = "Q #24: To avoid a condition called flickering, a frame needs to be refreshed",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #25
            new Question
            {
                Title = "Q #25: Pixels are also known as picture elements",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #26
            new Question
            {
                Title = "Q #26: For colour TV, each pixel represents 8 bits",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #27
            new Question
            {
                Title = "Q #27: For black and white TV, each pixel represents 8 bits",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #28
            new Question
            {
                Title = "Q #28: For colour TV, each pixel designates 8 bits for each primary colour (red, blue, yellow)",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #29
            new Question
            {
                Title = "Q #29: A video's dimensions are 1920x1080 pixels (in colour), and is played at 25 frames per second (with refreshing). This means we need a ___________ Mbps bitrate",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "944"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "2488"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "1024"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "2048"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #30
            new Question
            {
                Title = "Q #30: In ______________ encoding, the differences between the samples are encoded instead of encoding all the sampled values",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Predictive"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Perceptual"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Perpetual"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Compressed"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #31
            new Question
            {
                Title = "Q #31: Predictive encoding is often used for creating CD-quality audio",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #32
            new Question
            {
                Title = "Q #32: Predictive encoding is often used for speech",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #33
            new Question
            {
                Title = "Q #33: The idea of _____________ encoding is based on the limitations of our auditory system",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Predictive"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Perceptual"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Perpetual"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Compressed"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #34
            new Question
            {
                Title = "Q #34: Perceptual encoding is often used for creating CD-quality audio",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #35
            new Question
            {
                Title = "Q #35: Perceptual encoding is often used for speech",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #36
            new Question
            {
                Title = "Q #36: MP3 uses predictive encoding",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #37
            new Question
            {
                Title = "Q #37: JPEG is a standard which is used to compress images",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #38
            new Question
            {
                Title = "Q #38: MPEG is a standard which is used to compress audio",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #39
            new Question
            {
                Title = "Q #39: JPEG works by",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Changing the picture into a linear set of numbers so that redundancies can be found and removed"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Partitioning the picture into I-frames, P-frames, and B-frames"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Changing the colour of pixels that are similar to the colour of other pixels so they are the same"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Changing the size of the picture so that it is smaller"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #40
            new Question
            {
                Title = "Q #40: The steps for JPEG compression are (in order from first to last)",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "DCT, Quantization, Data Compression"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Quantization, DCT, Data Compression"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "DCT, Data Compression, Quantization"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Data Compression, Quantization, DCT"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #41
            new Question
            {
                Title = "Q #41: Discrete cosine transformation changes a block of 64 values so that the relative relationships between pixels are kept but the redundancies are revealed ",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #42
            new Question
            {
                Title = "Q #42: DCT is irreversable ",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #43
            new Question
            {
                Title = "Q #43: In DCT, the value T(0, 0) in the transformation table is called the AC value",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #44
            new Question
            {
                Title = "Q #44: In DCT, the value T(0, 0) in the transformation table is called the DC value",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #45
            new Question
            {
                Title = "Q #45: In DCT, the value T(m, n), exluding the value T(0, 0) in the transformation table, is called the AC value",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #46
            new Question
            {
                Title = "Q #46: In DCT, the DC values are the changes in the colours of the pixels",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #47
            new Question
            {
                Title = "Q #47: In DCT, the DC value is the average value (multiplied by a constant) of the pixels",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #48
            new Question
            {
                Title = "Q #48: JPEG compression is called \"lossy\" because of the",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "DCT phase"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Quantization phase"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Compression phase"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "JPEG is not \"lossy\""
                    }
                },
                CorrectAnswer = 1
            },
            // Question #49
            new Question
            {
                Title = "Q #49: For JPEG compression, the compression phase is read",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "In a zigzag fashion"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Row by row"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Column by column"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #50
            new Question
            {
                Title = "Q #50: Compressing video means spatially compressing each frame and temporally compressing a set of frames",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #51
            new Question
            {
                Title = "Q #51: Spatial compression in MPEG is done with JPEG (or a modification of it)",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #52
            new Question
            {
                Title = "Q #52: Spatial compression in MPEG is done with PNG",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #53
            new Question
            {
                Title = "Q #53: The 3 categories that MPEG divides its frames into are",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "I-frames, P-frames, and B-frames"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "A-frames, B-frames, and C-frames"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "B-frames, P-frames, and R-frames"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "T-frames, I-frames, and B-frames"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #54
            new Question
            {
                Title = "Q #54: ___________ is an independent frame that is not related to any other frame",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "I-frames"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "P-frames"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "B-frames"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #55
            new Question
            {
                Title = "Q #55: ___________ is predicted frame that is related to the preceding frame",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "I-frames"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "P-frames"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "B-frames"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #56
            new Question
            {
                Title = "Q #56: ___________ is a bidirectional frame that is related to the preceding and following frame",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "I-frames"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "P-frames"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "B-frames"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #57
            new Question
            {
                Title = "Q #57: A B-frame can be related to another B-frame",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #58
            new Question
            {
                Title = "Q #58: A P-frame can be related to an I-frame",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #59
            new Question
            {
                Title = "Q #59: When using only a web server to download an audio/video file, the file can be played before the downloading has finished",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #60
            new Question
            {
                Title = "Q #60: When using a web server with a metafile to download an audio/video file, the media player is directly connected to the Web server for downloading the file",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #61
            new Question
            {
                Title = "Q #61: When using a web server with a metafile to download an audio/video file, the Web server only stores the actual audio/video file",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #62
            new Question
            {
                Title = "Q #62: A problem when using a web server with a metafile to download an audio/video file is that the browser and  media player both use HTTP. ",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #63
            new Question
            {
                Title = "Q #63: When using a web server with a media server to download an audio/video file, the media player uses the URL in the metafile to access the media server to download the file",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #64
            new Question
            {
                Title = "Q #64: The protocol used to download a file from a web server to your browser should utilize TCP, in case a damaged file needs to be retransmitted",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #65
            new Question
            {
                Title = "Q #65: Real-Time Streaming Protocol is an in-band control protocol",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #66
            new Question
            {
                Title = "Q #66: Real-Time Streaming Protocol is an out-of-band control protocol",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #67
            new Question
            {
                Title = "Q #67: Real-Time Streaming Protocol is used to",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Control the playing of audio/video"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Display the video in a video player"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Compress the video so that it can be efficiently downloaded from a web server"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Allow users to interact with another user through the Internet"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #68
            new Question
            {
                Title = "Q #68: Real-Time Streaming Protocol defines a compression scheme for audio and video",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #69
            new Question
            {
                Title = "Q #69: Real-Time Streaming Protocol does not define how audio and video are encapsulated in packets for transmission over a network",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #70
            new Question
            {
                Title = "Q #70: Real-Time Streaming Protocol can only be transported using UDP",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #71
            new Question
            {
                Title = "Q #71: Real-Time Streaming Protocol does not restrict how the media player buffers the audio/video",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #72
            new Question
            {
                Title = "Q #72: The media stream used when streaming a video from a web server is considered in-band",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #73
            new Question
            {
                Title = "Q #73: Streaming ________ audio/video is multicast",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Stored"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Live"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #74
            new Question
            {
                Title = "Q #74: Streaming ________ audio/video is unicast",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Stored"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Live"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #75
            new Question
            {
                Title = "Q #75: When using real-time interactive audio/video, the time relationship between the packets is preserved",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #76
            new Question
            {
                Title = "Q #76: Jitter is the variation of packet delay",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #77
            new Question
            {
                Title = "Q #77: Real-time traffic in interactive audio/video does not require a playback buffer",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #78
            new Question
            {
                Title = "Q #78: Client-side _______________________ compensate for delay jitter",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Buffering"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Playback delay"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "All of the above"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "None of the above"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #79
            new Question
            {
                Title = "Q #79: RTP provides which of the following features for real-time interactive audio/video",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Mixing, multicasting, ordering"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Ordering, unicasting, mixing"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Timing, multicasting, retransmission"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Multicasting, unicasting, ordering"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #80
            new Question
            {
                Title = "Q #80: TCP is used for real-time interactive multimedia",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #81
            new Question
            {
                Title = "Q #81: What protocol is used for real-time interactive multimedia",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "RTP"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "UDP"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "TCP"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "RTP and UDP"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #82
            new Question
            {
                Title = "Q #82: RTP does not have a delivery mechanism",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #83
            new Question
            {
                Title = "Q #83: RTP runs beneath UDP",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #84
            new Question
            {
                Title = "Q #84: RTP packet headers can have a maximum of 31 contributors because the 5-bit field allows the numbers 0-31",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #85
            new Question
            {
                Title = "Q #85: The sender of a audio/video stream can change the encoding on the fly",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #86
            new Question
            {
                Title = "Q #86: The initial sequence number of an RTP packet is 0, and is then incremented by 1 for each subsequent packet",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #87
            new Question
            {
                Title = "Q #87: RTP packets add a SSRC field, which",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Defines the source(s)"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Defines the receiver(s)"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Defines the packet quality"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Defines the packet quantity"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #88
            new Question
            {
                Title = "Q #88: RTCP works in conjunction with",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "RTP"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "UDP"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "TCP"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "RTSP"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #89
            new Question
            {
                Title = "Q #89: RTCP is used when",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "The networking application multicasts audio/video to multiple receivers from one or more senders"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "The sender wants the receiver to have control the playback of the audio/video"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "The application controls who the audio/video is sent to"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "The network congestion prevents users from playing the streamed multimedia without buffering"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #90
            new Question
            {
                Title = "Q #90: RTP and RTSP packets are distinguished from each other through the use of distinct port numbers",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #91
            new Question
            {
                Title = "Q #91: RTP and RTCP packets are distinguished from each other through the use of distinct port numbers",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #92
            new Question
            {
                Title = "Q #92: RTCP packets encapsulate chunks of audio or video",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #93
            new Question
            {
                Title = "Q #93: RTCP packets contain sender and/or receiver reports",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #94
            new Question
            {
                Title = "Q #94: RTCP __________________ are sent periodically by the active senders in a conference to report transmission and reception statistics for all RTP packets sent during the interval",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sender report packets"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Receiver reception packets"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Source description packets"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Bye messages"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #95
            new Question
            {
                Title = "Q #95: RTCP __________________ are for passive participants, those that do not send RTP packets. The report informs the sender and other receivers about the quality of service.",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sender report packets"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Receiver reception packets"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Source description packets"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Bye messages"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #96
            new Question
            {
                Title = "Q #96: RTCP __________________ can include the email address of the sender, the sender's name, and the application that generates the RTP stream",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sender report packets"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Receiver reception packets"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Source description packets"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Bye messages"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #97
            new Question
            {
                Title = "Q #97: RTCP __________________ are for an application that wants to use new applications not defined in the standard. It allows the definition of a new message type.",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sender report packets"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Receiver reception packets"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Source description packets"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Bye messages"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #98
            new Question
            {
                Title = "Q #98: RTCP __________________ are messages that shut down a stream",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sender report packets"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Receiver reception packets"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Source description packets"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Bye messages"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #99
            new Question
            {
                Title = "Q #99: RTP port numbers must be",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "An even number"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "An odd number"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "A prime number"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #100
            new Question
            {
                Title = "Q #100: RTCP port numbers must be",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "An even number"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "An odd number"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "A prime number"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #101
            new Question
            {
                Title = "Q #101: RTP port numbers must immediately follow a RTCP port number",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #102
            new Question
            {
                Title = "Q #102: VoIP allows communication between two parties over a ___________ network",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Packet-switched"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Circuit-switched"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #103
            new Question
            {
                Title = "Q #103: What is session initiation protocol (SIP)?",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "It is a standard that allows telephones on the public telephone network to talk to computers connected to the internet"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "It is an application layer protocol that establishes, manages, and terminates a multimedia session (call)"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "It is a method for implementing virtual private networks"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "It lets a server and client have multiple conversations over a single TCP connection"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #104
            new Question
            {
                Title = "Q #104: SIP is a text-based protocol",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #105
            new Question
            {
                Title = "Q #105: SIP defines the following messages",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "INVITE, ACK, BYE, OPTIONS, CANCEL, REGISTER"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "PING, RECEIVE, END, MESSAGE, CREATE, BYE"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "CREATE, RESTORE, ACK, RECEIVE, CANCEL, INVITE"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "HELO, ACK, WAIT, OPTIONS, BYE, CANCEL, LOGIN"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #106
            new Question
            {
                Title = "Q #106: Which of the following is a valid SIP address?",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Sip:tom@201.23.45.78"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Sip@tom:fhda.edu"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "201.23.45.78@sip:tom"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Fhda.edu:sip@tom"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #107
            new Question
            {
                Title = "Q #107: Establishing a session in SIP requires a",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "2 way handshake"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "3 way handshake"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "4 way handshake"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "5 way handshake"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #108
            new Question
            {
                Title = "Q #108: A SIP session is terminated with the CANCEL message sent by either party",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #109
            new Question
            {
                Title = "Q #109: What is H.323?",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "It is a standard that allows telephones on the public telephone network to talk to computers connected to the internet"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "It is an application layer protocol that establishes, manages, and terminates a multimedia session (call)."
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "It defines a set of quality-of-service enhancements for wireless LAN applications through modifications to the Media Access Control (MAC) layer"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "It is designed to compensate for the differences between traditional packet-less communications over analog lines and packet-based transmissions which are the basis for IP communications"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #110
            new Question
            {
                Title = "Q #110: What is a gateway?",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "It connects the Internet to the telephone network"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "It is a running instance of an application capable of accepting requests from the client and giving responses accordingly"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "It is an endpoint of an inter-process communication flow across a computer network"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #111
            new Question
            {
                Title = "Q #111: Which of the following are characteristic types attributed to flow",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "Reliability"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "Delay"
                    },
                    new Choice
                    {
                        Order = 3,
                        Description = "Jitter"
                    },
                    new Choice
                    {
                        Order = 4,
                        Description = "Bandwidth"
                    }
                },
                CorrectAnswer = 1
            },
            // Question #112
            new Question
            {
                Title = "Q #112: Network loss happens when the packet arrives too late for playback at the receiver",
                Choices = new List<Choice>
                {
                    new Choice
                    {
                        Order = 1,
                        Description = "True"
                    },
                    new Choice
                    {
                        Order = 2,
                        Description = "False"
                    }
                },
                CorrectAnswer = 1
            }
        };
        private static List<Question> AllShuffled => All.OrderBy(x => random.Next()).ToList();
    }
}

