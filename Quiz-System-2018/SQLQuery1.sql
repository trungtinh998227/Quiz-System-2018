create table DAPAN(
	[MaCauHoi] nchar(10) not null,
	[SoDapAn] int,
	CONSTRAINT [FK_DAPAN_CAUHOI] FOREIGN KEY (MaCauHoi) REFERENCES [dbo].[CAUHOI] (MaCauHoi) ON DELETE CASCADE
);